using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Domain.ValueObjects
{
    /// <summary>
    /// 薪资
    /// </summary>
    public class Salary
    {
        /// <summary>
        /// 日薪
        /// </summary>
        public decimal Day { get; set; }
        /// <summary>
        /// 时薪
        /// </summary>
        public decimal Hour { get; set; }
    }
}
