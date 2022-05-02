// See https://aka.ms/new-console-template for more information




using System.Text;
using System.Text.RegularExpressions;

System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

string path = @"..\..\..\..\MT5.Bridge.CTP.Wrapper\ctp\x86\ThostFtdcUserApiDataType.h";



#region 解析 生成type
List<CTPType> types = new List<CTPType>();

using (var sr = new StreamReader(path))
{
    var data = sr.ReadToEnd();

    var ms = Regex.Matches(data, @"/+\r\n(///.+)\r\n/+\r\n((?:///.*\r\n\#.*\r\n)*)[\r\n]*typedef\s(\w+)\s(.*);", RegexOptions.Multiline);

    foreach (Match m in ms)
    {
        var t = new CTPType();
        t.Description = m.Groups[1].Value;
        t.Name = m.Groups[^1].Value;
        t.Type = m.Groups[^2].Value switch
        {
            "char" => typeof(char),
            "int" => typeof(int),
            "float" => typeof(float),
            "double" => typeof(double),
            "short" => typeof(short),
            _ => null,
        };
        if (t.Type == typeof(char))
        {
            var tmp = Regex.Match(t.Name, @"(\w+)\[(\d+)\]");
            if (tmp.Success)
            {
                t.Name = tmp.Groups[1].Value;
                t.Size = int.Parse(tmp.Groups[2].Value);
            }
        }
        if (m.Groups[2].Value.Length > 0)
        {
            t.Defined = m.Groups[2].Value;

            var mmm = Regex.Matches(t.Defined, @"(///.+)\r\n#define (\w+) '(\w+)'\r\n");
            if (mmm.Count() == 0) throw new Exception();
            foreach (Match item in mmm)
            {
                if (item.Success)
                {
                    t.EnumValues.Add(new CTPEnum { Name = item.Groups[2].Value, Description = item.Groups[1].Value, Value = item.Groups[3].Value });
                }
            }
        }

        types.Add(t);
    }

}

path = @"..\..\..\..\MT5.Bridge.CTP.Wraper\ctp\x86\ThostFtdcUserApiStruct.h";
List<CTPStruct> structs = new List<CTPStruct>();
using (var sr = new StreamReader(path))
{
    var data = sr.ReadToEnd();

    var ms = Regex.Matches(data, @"(///.+)\r\nstruct (\w+)\r\n\{\r\n([^\}]+)\}", RegexOptions.Multiline);
    foreach (Match item in ms)
    {
        var t = new CTPStruct();
        t.Name = item.Groups[2].Value;
        t.Description = item.Groups[1].Value;

        var mm = Regex.Matches(item.Groups[3].Value, @"(///.*)\r\n\s+(\w+)\s*(\w+)");
        foreach (Match m in mm)
        {
            var f = new CTPObject();
            f.Description = m.Groups[1].Value;
            f.Name = m.Groups[3].Value;
            f.TypeName = m.Groups[2].Value;
            f.Type = types.Find(t => t.Name == f.TypeName);
            t.Fields.Add(f);
        }
        structs.Add(t);
        //
    }
}

#endregion

#region 生成类型文件
using (var sw = new StreamWriter(@"..\..\..\..\MT5.Bridge.CTP\Types.cs"))
{
    //生成文件
    sw.WriteLine("using System;\r\nusing System.Runtime.InteropServices;\r\n\r\n");
    //生成using type = ...
    sw.WriteLine("#region Types");
    foreach (var t in types)
    {
        sw.WriteLine($"{t.Description}");
        if (t.Type == typeof(char))
        {
            if (t.Size == 0 && t.EnumValues.Count == 0)
                sw.WriteLine($"using {t.Name} = {t.Type};");
            else
                sw.WriteLine($"using {t.Name} = System.String;");
        }
        else
            sw.WriteLine($"using {t.Name} = {t.Type};");
    }
    sw.WriteLine("#endregion\r\n\r\n");
    sw.WriteLine("namespace Bridge.CTP\r\n{");

    sw.WriteLine("\t#region Enums");
    //ENUM
    sw.WriteLine(@"    
    enum THOST_TE_RESUME_TYPE 
    {
        THOST_TERT_RESTART = 0,
        THOST_TERT_RESUME,
        THOST_TERT_QUICK,
        THOST_TERT_NONE
    }; ");

    foreach (var t in types.Where(x => x.EnumValues.Count > 0))
    {
        bool ischar = t.EnumValues.All(x => x.Value.Length == 1);
        if (ischar)
            sw.WriteLine($"\tpublic enum {t.Name}:byte\r\n\t{{\r\n");
        else
            sw.WriteLine($"\tpublic enum {t.Name}\r\n\t{{\r\n");

        foreach (var ev in t.EnumValues)
        {
            if (ischar)
                sw.WriteLine($"\t\t{ev.Description}\r\n\t\t{ev.Name} = (byte)('{ev.Value}'),");
            else sw.WriteLine($"\t\t{ev.Description}\r\n\t\t{ev.Name} = {int.Parse(ev.Value)},");
        }

        sw.WriteLine($"\r\n\t}};\r\n");
    }

    sw.WriteLine("\t#endregion Enums\r\n\r\n");


    sw.WriteLine("\t#region Structs");
    foreach (var t in structs)
    {
        sw.WriteLine($"\r\n\t{t.Description}\r\n\t[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 0)]\r\n\tpublic class {t.Name}\r\n\t{{");
        foreach (var f in t.Fields)
        {
            sw.WriteLine($"\t\t{f.Description}");

            var ty = f.Type;
            if (ty == null)
            {
                Console.WriteLine($"{t.Name} {f.Name} ERROR");
                continue;
            }
            if (ty.Type == typeof(char) && ty.Size > 0)
                sw.WriteLine($"\t\t[MarshalAs(UnmanagedType.ByValTStr, SizeConst = {ty.Size})]\r\n\t\tpublic {f.TypeName} {f.Name};");
            else if (ty.Type == typeof(char))
                sw.WriteLine($"\t\t[MarshalAs(UnmanagedType.I1)]\r\n\t\tpublic {f.TypeName} {f.Name};");
            else
                sw.WriteLine($"\t\tpublic {f.TypeName} {f.Name};");
        }
        sw.WriteLine("\t}");
    }


    sw.WriteLine("\t#endregion Structs\r\n\r\n");


    sw.WriteLine("}");

    sw.Flush();
}
#endregion


#region parse trader

//解释trader 类
var trade_api = new List<CTPFunc>();
var trade_spi = new List<CTPFunc>();
using (var sr = new StreamReader(@"..\..\..\..\MT5.Bridge.CTP.Wraper\ctp\x86\ThostFtdcTraderApi.h"))
{
    var data = sr.ReadToEnd();

    //分开2个class
    var ms = Regex.Matches(data, @"class");
    var spi = data.Substring(ms[0].Index, ms[1].Index - ms[0].Index);
    var api = data.Substring(ms[1].Index, data.Length - ms[1].Index);


    ms = Regex.Matches(spi, @"((?:\s*///.*\r\n)+)\s+virtual\s+((?:const\s)*\w+)\s+([^\(]+)\((.*)\).*\r\n", RegexOptions.Multiline);
    Console.WriteLine($"Trader Spi Function {Regex.Matches(spi, "virtual").Count}个, 解析虚函数{ms.Count}个");
    foreach (Match match in ms)
    {
        var func = new CTPFunc();
        func.Description = match.Groups[1].Value.Trim();
        //if (func.Description.EndsWith("\r\n")) func.Description = func.Description[..^2];
        func.ReturnType = match.Groups[2].Value;
        func.Name = match.Groups[3].Value;
        if (func.Name.StartsWith("*"))
        {
            func.Name = func.Name[1..];
            func.ReturnType += "*";
        }

        func.ParamStr = match.Groups[4].Value;

        var mm = Regex.Matches(match.Groups[4].Value, @"(\w+)\s+([^,]+)");
        foreach (Match m in mm)
        {
            var pa = new CTPParam { TypeName = m.Groups[1].Value, Type = types.Find(x => x.Name == m.Groups[1].Value), Name = m.Groups[2].Value };
            pa.Name = pa.Name.Replace(" ", "");
            if (pa.Name.StartsWith("*"))
            {
                pa.TypeName += "*";
                pa.Name = pa.Name[1..];
            }

            func.Params.Add(pa);
        }
        trade_spi.Add(func);
    }

    ms = Regex.Matches(api, @"((?:\s*///.*\r\n)+)\s+virtual\s+((?:const\s)*\w+)\s+([^\(]+)\((.*)\).*\r\n", RegexOptions.Multiline);
    Console.WriteLine($"Trader Api Function {Regex.Matches(api, "virtual").Count + 2}个, 解析虚函数{ms.Count}个");
    foreach (Match match in ms)
    {
        var func = new CTPFunc();
        func.Description = match.Groups[1].Value.Trim();
        //if (func.Description.EndsWith("\r\n")) func.Description = func.Description[..^2];
        func.ReturnType = match.Groups[2].Value;
        func.Name = match.Groups[3].Value;
        if (func.Name.StartsWith("*"))
        {
            func.Name = func.Name[1..];
            func.ReturnType += "*";
        }
        func.ParamStr = match.Groups[4].Value;

        var mm = Regex.Matches(match.Groups[4].Value, @"(\w+)\s+([^,]+)");
        foreach (Match m in mm)
        {
            var pa = new CTPParam { TypeName = m.Groups[1].Value, Type = types.Find(x => x.Name == m.Groups[1].Value), Name = m.Groups[2].Value };
            pa.Name = pa.Name.Replace(" ", "");
            if (pa.Name.StartsWith("*"))
            {
                pa.TypeName += "*";
                pa.Name = pa.Name[1..];
            }

            func.Params.Add(pa);
        }
        trade_api.Add(func);
    }
}

foreach (var f in trade_api)
{
    var op = trade_spi.FirstOrDefault(x => x.Name == f.Name.Replace("Req", "OnRsp"));
    if (op != null)
    {
        f.CallBack = op.Name + "Handler";
    }
    Console.WriteLine($"{f.Name}, {f.CallBack}");
}
Dictionary<string, string> map = new Dictionary<string, string>();
map.Add("Init", "");
#endregion


Console.WriteLine($"Trader Api:{trade_api.Count} Spi:{trade_spi.Count} 无关联：{string.Join(" ", trade_api.Where(x => x.CallBack == null).Select(x => x.Name))}");

#region parse quoter

//解释md 类
var user_api = new List<CTPFunc>();
var user_spi = new List<CTPFunc>();
using (var sr = new StreamReader(@"..\..\..\..\MT5.Bridge.CTP.Wraper\ctp\x86\ThostFtdcMdApi.h"))
{
    var data = sr.ReadToEnd();
    data = Regex.Replace(data, "(?=[^\r])\n", "\r\n");

    //分开2个class
    var ms = Regex.Matches(data, @"class");
    var spi = data.Substring(ms[0].Index, ms[1].Index - ms[0].Index);
    var api = data.Substring(ms[1].Index, data.Length - ms[1].Index);


    ms = Regex.Matches(spi, @"((?:\s*///.*$)+)\s+virtual\s+((?:const\s)*\w+)\s*([^\(]+)\((.*)\).*", RegexOptions.Multiline);
    Console.WriteLine($"User Spi Function {Regex.Matches(spi, "virtual").Count}个, 解析虚函数{ms.Count}个");
    foreach (Match match in ms)
    {
        var func = new CTPFunc();
        func.Description = match.Groups[1].Value.Trim();
        func.ReturnType = match.Groups[2].Value;
        func.Name = match.Groups[3].Value;
        if (func.Name.StartsWith("*"))
        {
            func.Name = func.Name[1..];
            func.ReturnType += "*";
        }

        func.ParamStr = match.Groups[4].Value;

        var mm = Regex.Matches(match.Groups[4].Value, @"(\w+)\s+([^,]+)");
        foreach (Match m in mm)
        {
            var pa = new CTPParam { TypeName = m.Groups[1].Value, Type = types.Find(x => x.Name == m.Groups[1].Value), Name = m.Groups[2].Value };
            pa.Name = pa.Name.Replace(" ", "");
            if (pa.Name.StartsWith("*"))
            {
                pa.TypeName += "*";
                pa.Name = pa.Name[1..];
            }

            func.Params.Add(pa);
        }
        user_spi.Add(func);
    }

    ms = Regex.Matches(api, @"((?:\s*///.*$)+)\s+virtual\s+((?:const\s)*\w+)\s+([^\(]+)\((.*)\).*$", RegexOptions.Multiline);
    Console.WriteLine($"User Api Function {Regex.Matches(api, "virtual").Count + 2}个, 解析虚函数{ms.Count}个");
    foreach (Match match in ms)
    {
        var func = new CTPFunc();
        func.Description = match.Groups[1].Value.Trim();
        func.ReturnType = match.Groups[2].Value;
        func.Name = match.Groups[3].Value;
        if (func.Name.StartsWith("*"))
        {
            func.Name = func.Name[1..];
            func.ReturnType += "*";
        }
        func.ParamStr = match.Groups[4].Value;

        var mm = Regex.Matches(match.Groups[4].Value, @"(\w+)\s+([^,]+)");
        foreach (Match m in mm)
        {
            var pa = new CTPParam { TypeName = m.Groups[1].Value, Type = types.Find(x => x.Name == m.Groups[1].Value), Name = m.Groups[2].Value };
            pa.Name = pa.Name.Replace(" ", "");
            if (pa.Name.StartsWith("*"))
            {
                pa.TypeName += "*";
                pa.Name = pa.Name[1..];
            }

            func.Params.Add(pa);
        }
        user_api.Add(func);
    }
}

//映射 
foreach (var f in user_api)
{
    var op = trade_spi.FirstOrDefault(x => x.Name.Replace("Rsp", "OnReq") == f.Name);
    if (op != null)
    {
        f.CallBack = op + "Handler";
    }
    Console.WriteLine($"{f.Name}, {f.CallBack}");
}

Console.WriteLine($"Quoter Api:{user_api.Count} Spi:{trade_spi.Count} 无关联：{string.Join(" ", trade_api.Where(x => x.CallBack == null).Select(x => x.Name))}");

#endregion
//生成trader warp 头文件
//生成 shared.h 包含 __declspec(dllexport) stdcall 及handle 定义


#region shared

using (var sw = new StreamWriter(@"..\..\..\..\MT5.Bridge.CTP.Wraper\shared.h"))
{
    sw.WriteLine("#pragma once\r\n\r\n#ifdef _WIN64");
    sw.WriteLine("#include \"./ctp/x64/ThostFtdcUserApiDataType.h\"");
    sw.WriteLine("#include \"./ctp/x64/ThostFtdcUserApiStruct.h\"");
    sw.WriteLine("#include \"./ctp/x64/ThostFtdcMdApi.h\"");
    sw.WriteLine("#include \"./ctp/x64/ThostFtdcTraderApi.h\"");
    sw.WriteLine("#else");
    sw.WriteLine("#include \"./ctp/x86/ThostFtdcUserApiDataType.h \"");
    sw.WriteLine("#include \"./ctp/x86/ThostFtdcUserApiStruct.h\"");
    sw.WriteLine("#include \"./ctp/x86/ThostFtdcMdApi.h\"");
    sw.WriteLine("#include \"./ctp/x86/ThostFtdcTraderApi.h\"");
    sw.WriteLine("#endif\r\n\r\n");
    sw.WriteLine("#define CTP_API extern __declspec(dllexport) ");
    sw.WriteLine("#define CTPCALL	__stdcall ");

    sw.WriteLine("\r\n");

    // 生成handler 
    foreach (var func in trade_spi)
    {
        sw.WriteLine($"{func.Description.Replace("\t", "")}\r\ntypedef {func.ReturnType}(CTPCALL *{func.Name}Handler)({func.ParamStr});");
    }

    foreach (var func in user_spi.Where(x => !trade_spi.Any(y => y.Name == x.Name)))
    {
        sw.WriteLine($"{func.Description.Replace("\t", "")}\r\ntypedef {func.ReturnType}(CTPCALL *{func.Name}Handler)({func.ParamStr});");
    }


    sw.Flush();
}
#endregion

#region trader
using (var sw = new StreamWriter(@"..\..\..\..\MT5.Bridge.CTP.Wraper\trader.h"))
{
    sw.WriteLine("#pragma once\r\n\r\n#include \"shared.h\"\r\n\r\n");

    sw.WriteLine(@"
class CTraderHandler : public CThostFtdcTraderSpi
{
private:
	CThostFtdcTraderApi* api;

	const char* m_flow_path;
 
public:
	CThostFtdcTraderApi* Api() { return api; }

public:
	CTraderHandler(const char* path) :m_flow_path(path)
	{
		api = CThostFtdcTraderApi::CreateFtdcTraderApi(path);
		api->RegisterSpi(this);
	}

	~CTraderHandler()
	{
		if (api != nullptr)
		{ 
			api->Release();
			api = nullptr;
		}
	}");

    //写入handler 
    sw.WriteLine("\r\nprivate:\r\n");
    foreach (var func in trade_spi)
    {
        sw.WriteLine($"\t{func.Description}\r\n\t{func.Name}Handler _{func.Name}Handler = nullptr;");
    }


    //写入set handler
    sw.WriteLine("\r\npublic:\r\n");
    foreach (var func in trade_spi)
    {
        sw.WriteLine($"\t{func.Description}\r\n\tvoid Set{func.Name}Handler({func.Name}Handler handler) {{\r\n\t\t_{func.Name}Handler = handler;\r\n\t}}");
    }

    //写入func
    sw.WriteLine("\r\npublic:\r\n");
    foreach (var func in trade_spi)
    {
        sw.WriteLine($"\t{func.Description}\r\n\t{func.ReturnType} {func.Name}({func.ParamStr}) override{{\r\n\t\tif(_{func.Name}Handler) _{func.Name}Handler({string.Join(',', func.Params.Select(x => x.Name))});\r\n\t}}");
    }




    sw.WriteLine("};");
    sw.Flush();
}
#endregion


#region quoter
using (var sw = new StreamWriter(@"..\..\..\..\MT5.Bridge.CTP.Wraper\quoter.h"))
{
    sw.WriteLine("#pragma once\r\n\r\n#include \"shared.h\"\r\n\r\n");

    sw.WriteLine(@"
class CQuoterHandler : public CThostFtdcMdSpi
{
private:
	CThostFtdcMdApi* api;

	const char* m_flow_path;
 
public:
	CThostFtdcMdApi* Api() { return api; }

public:
	CQuoterHandler(const char* path, const bool bIsUsingUdp=false, const bool bIsMulticast=false):m_flow_path(path)
	{
		api = CThostFtdcMdApi::CreateFtdcMdApi(path);
		api->RegisterSpi(this);
	}

	~CQuoterHandler()
	{
		if (api != nullptr)
		{ 
			api->Release();
			api = nullptr;
		}
	}");

    //写入handler 
    sw.WriteLine("\r\nprivate:\r\n");
    foreach (var func in user_spi)
    {
        sw.WriteLine($"\t{func.Description}\r\n\t{func.Name}Handler _{func.Name}Handler = nullptr;");
    }


    //写入set handler
    sw.WriteLine("\r\npublic:\r\n");
    foreach (var func in user_spi)
    {
        sw.WriteLine($"\t{func.Description}\r\n\tvoid Set{func.Name}Handler({func.Name}Handler handler) {{\r\n\t\t_{func.Name}Handler = handler;\r\n\t}}");
    }

    //写入func
    sw.WriteLine("\r\npublic:\r\n");
    foreach (var func in user_spi)
    {
        sw.WriteLine($"\t{func.Description}\r\n\t{func.ReturnType} {func.Name}({func.ParamStr}) override{{\r\n\t\tif(_{func.Name}Handler) _{func.Name}Handler({string.Join(',', func.Params.Select(x => x.Name))});\r\n\t}}");
    }




    sw.WriteLine("};");
    sw.Flush();
}

#endregion


#region export
using (var sw = new StreamWriter(@"..\..\..\..\MT5.Bridge.CTP.Wraper\export.h"))
{
    sw.WriteLine("#pragma once\r\n\r\n#include \"shared.h\"\r\n#include \"trader.h\"\r\n#include \"quoter.h\"\r\n\r\n");

    sw.WriteLine("#ifdef __cplusplus\r\nextern \"C\" {\r\n#endif\r\n\r\n");

    sw.WriteLine("\tCTP_API void* CTPCALL TdCreateApi(const char* pszFlowPath){{\r\n\t\treturn new CTraderHandler(pszFlowPath);\r\n\t}}");
    sw.WriteLine("\tCTP_API const char* CTPCALL TdGetApiVersion(){{\r\n\t\treturn CThostFtdcMdApi::GetApiVersion();\r\n\t}}");

    foreach (var func in trade_api)
    {
        string retstr = func.ReturnType.Contains("void") ? string.Empty : "return ";

        if (func.Name == "Release")
        {
            sw.WriteLine(@$"
    {func.Description}
    CTP_API {func.ReturnType} CTPCALL Td{func.Name}(void * spi) {{
        if(spi) delete spi;
    }}");
        }
        else if (func.Params.Any())
        {
            sw.WriteLine(@$"
    {func.Description}
    CTP_API {func.ReturnType} CTPCALL Td{func.Name}(void * spi,{func.ParamStr}) {{
        {retstr}(static_cast<CTraderHandler*>(spi))->Api()->{func.Name}({string.Join(',', func.Params.Select(x => x.Name))});
    }}");
        }
        else
        {
            sw.WriteLine(@$"
    {func.Description}
    CTP_API {func.ReturnType} CTPCALL Td{func.Name}(void * spi) {{
        {retstr}(static_cast<CTraderHandler*>(spi))->Api()->{func.Name}();
    }}");
        }

    }

    Console.WriteLine();

    foreach (var func in trade_spi)
    {
        sw.WriteLine($"\t{func.Description}\r\n\tCTP_API void CTPCALL TdSet{func.Name}Handler(void* spi, {func.Name}Handler handler) {{\r\n\t\t(static_cast<CTraderHandler*>(spi))->Set{func.Name}Handler(handler);\r\n\t}}\r\n");
    }

    Console.WriteLine();

    foreach (var func in user_api)
    {
        string retstr = func.ReturnType.Contains("void") ? string.Empty : "return ";

        if (func.Name == "Release")
        {
            sw.WriteLine(@$"
    {func.Description}
    CTP_API {func.ReturnType} CTPCALL Md{func.Name}(void * spi) {{
        if(spi) delete spi;
    }}");
        }
        else if (func.Params.Any())
        {
            sw.WriteLine(@$"
    CTP_API {func.ReturnType} CTPCALL Md{func.Name}(void * spi,{func.ParamStr}) {{
        {retstr}(static_cast<CQuoterHandler*>(spi))->Api()->{func.Name}({string.Join(',', func.Params.Select(x => x.Name.Replace("[]", "")))});
    }}");
        }
        else
        {
            sw.WriteLine(@$"
    CTP_API {func.ReturnType} CTPCALL Md{func.Name}(void * spi) {{
        {retstr}(static_cast<CQuoterHandler*>(spi))->Api()->{func.Name}();
    }}");
        }

        //}
    }

    Console.WriteLine();
    foreach (var func in user_spi)
    {
        sw.WriteLine($"\t{func.Description}\r\n\tCTP_API void CTPCALL MdSet{func.Name}Handler(void* spi, {func.Name}Handler handler) {{\r\n\t\t(static_cast<CQuoterHandler*>(spi))->Set{func.Name}Handler(handler);\r\n\t}}\r\n");
    }

    sw.WriteLine("\r\n\r\n#ifdef __cplusplus\r\n}\r\n#endif");
    sw.Flush();
}
#endregion



/// ////////////////////////////////////////////////////////////////////
string trade_cs = "";

File.Copy(@"D:\Projects\CTPBridge\Bridge.CTP\TradeApi.cs", @"..\..\..\..\MT5.Bridge.CTP\TradeApi.bak", true);

using (var sr = new StreamReader(@"D:\Projects\CTPBridge\Bridge.CTP\TradeApi.bak", Encoding.GetEncoding("GB2312")))
{
    trade_cs = sr.ReadToEnd();
}

using (var sw = new StreamWriter(@"..\..\..\..\MT5.Bridge.CTP\TradeApi.cs", false, Encoding.GetEncoding("GB2312")))
{
    int front = trade_cs.IndexOf("#region 回调入口");
    int back = trade_cs.LastIndexOf("#endregion Dll Functions") + "#endregion Dll Functions".Length;

    sw.WriteLine(trade_cs[..front]);

    //生成回调handler
    sw.WriteLine("\t\t#region 回调入口");
    sw.WriteLine("\t\tvoid InitCallback()\r\n\t\t{");
    foreach (var f in trade_spi)
    {
        sw.WriteLine($"\t\t\tTdSet{f.Name}Handler(Handle, ({string.Join(',', f.Params.Select(x => x.Name))})=>{f.Name}?.Invoke({string.Join(',', f.Params.Select(x => x.Name))}));");
    }
    sw.WriteLine("\t\t}\r\n\r\n");

    // 生成handler 
    foreach (var func in trade_spi)
    {
        sw.WriteLine($"\t\t{func.Description.Replace("\t", "\t\t")}\r\n\t\t[UnmanagedFunctionPointer(CallingConvention.StdCall)]\r\n\t\tpublic delegate {func.ReturnType} {func.Name}Handler({func.ParamStr.Replace("*", "")});");
        sw.WriteLine($"\t\tpublic event {func.Name}Handler {func.Name};");
        //sw.WriteLine($"\t\tprotected {func.ReturnType} {func.Name}Core({func.ParamStr.Replace("*", "")}) => {func.Name}?.Invoke({string.Join(',', func.Params.Select(x => x.Name))});\r\n");
        sw.WriteLine($"\t\t[DllImport(\"Bridge.CTP.Wrapped.dll\", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]\r\n\t\tprivate static extern void TdSet{func.Name}Handler(IntPtr spi, {func.Name}Handler handler);\r\n\r\n");
    }

    //foreach (var func in user_spi.Where(x => !trade_spi.Any(y => y.Name == x.Name)))
    //{
    //    sw.WriteLine($"\t\t{func.Description.Replace("\t", "\t\t")}\r\n\t\t[UnmanagedFunctionPointer(CallingConvention.StdCall)]\r\n\t\tprivate delegate {func.ReturnType} {func.Name}Handler ({func.ParamStr.Replace("*", "")});\r\n");
    //}

    sw.WriteLine("\t\t#endregion 回调入口\r\n\r\n");

    //生成dll入口
    sw.WriteLine("\t\t#region Dll Functions");

    sw.WriteLine("\t\t[DllImport(\"Bridge.CTP.Wrapped.dll\", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]\r\n\t\tprivate static extern IntPtr TdCreateApi(string pszFlowPath);\r\n");
    sw.WriteLine("\t\t[DllImport(\"Bridge.CTP.Wrapped.dll\", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]\r\n\t\tprivate static extern IntPtr TdGetApiVersion();\r\n");

    foreach (var func in trade_api)
    {
        if (func.Name.Trim() == "RegisterSpi")
            continue;

        var param = !string.IsNullOrWhiteSpace(func.ParamStr) ? ", " + Regex.Replace(func.ParamStr, @"(?:const\s*)*char\s*\*\s*", "string ").Replace("*", "") : "";
        var rettype = Regex.Replace(func.ReturnType, @"(?:const\s*)*char\s*\*\s*", "IntPtr ");
        var callback = !string.IsNullOrWhiteSpace(func.CallBack) ? $", {func.CallBack} handler" : "";

        sw.WriteLine($"\t\t{func.Description.Replace("\t", "\t\t")}\r\n\t\t[DllImport(\"Bridge.CTP.Wrapped.dll\", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]\r\n\t\t" +
            $"private static extern {rettype} Td{func.Name}(IntPtr api{param});\r\n");
    }

    //sw.WriteLine("\t\t[DllImport(\"Bridge.CTP.Wrapped.dll\", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]\r\n\t\tprivate static extern IntPtr MdCreateApi(string pszFlowPath);\r\n");
    //foreach (var func in user_api)
    //{
    //    if (func.Name == "RegisterSpi")
    //        continue;

    //    var param = !string.IsNullOrWhiteSpace(func.ParamStr) ? ", " + Regex.Replace(func.ParamStr, @"(?:const\s*)*char\s*\*\s*", "string ").Replace("*", "") : "";
    //    var rettype = Regex.Replace(func.ReturnType, @"(?:const\s*)*char\s*\*\s*", "string ");
    //    var callback = !string.IsNullOrWhiteSpace(func.CallBack) ? $", {func.CallBack} handler" : "";

    //    sw.WriteLine($"\t\t{func.Description.Replace("\t", "\t\t")}\r\n\t\t[DllImport(\"Bridge.CTP.Wrapped.dll\", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]\r\n\t\t" +
    //        $"private static extern {rettype} Md{func.Name}(IntPtr api{param}{callback});\r\n");
    //}

    sw.WriteLine("\t\t#endregion Dll Functions");


    sw.WriteLine(trade_cs[back..]);

    sw.Flush();
}















class CTPType
{
    public string Name { get; set; }

    public string Description { get; set; }

    public Type? Type { get; set; }

    public int Size { get; set; }


    public string Defined { get; set; }

    public List<CTPEnum> EnumValues { get; set; } = new List<CTPEnum>();

}


class CTPEnum
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string Value { get; set; }
}

class CTPObject
{
    public string Name { get; set; }

    public string Description { get; set; }

    public CTPType? Type { get; set; }

    public string TypeName { get; set; }

}

class CTPStruct
{
    public string Name { get; set; }

    public string Description { get; set; }

    public List<CTPObject> Fields { get; set; } = new List<CTPObject>();
}


class CTPFunc
{
    public string Name { get; set; }

    public string Description { get; set; }

    public string ReturnType { get; set; }

    public string ParamStr { get; set; }

    //对应函数req rsp
    public string CallBack { get; set; }

    public List<CTPParam> Params { get; set; } = new List<CTPParam>();
}




class CTPParam
{
    public string Name { get; set; }

    public CTPType? Type { get; set; }

    public string TypeName { get; set; }

}









