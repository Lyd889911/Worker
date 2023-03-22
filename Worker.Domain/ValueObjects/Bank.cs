using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Domain.ValueObjects
{
    /// <summary>
    /// 银行
    /// </summary>
    public class Bank
    {
        /// <summary>
        /// 银行卡
        /// </summary>
        public string? CardId { get; set; }
        /// <summary>
        /// 开户行名
        /// </summary>
        public string? OpeningName { get; set; }
    }
}
