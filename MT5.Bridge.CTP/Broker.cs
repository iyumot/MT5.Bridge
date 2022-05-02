using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CTP
{
    public interface IBroker
    {
        string ID { get; set; }

        string Name { get; set; }

        string[] TradeFront { get; set; }

        string[] MarketFront { get; set; }
    }

    public class Broker : IBroker
    {
        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 前置地址集
        /// </summary>
        public string[] TradeFront { get; set; }

        /// <summary>
        /// 前置地址集
        /// </summary>
        public string[] MarketFront { get; set; }
    }
}
