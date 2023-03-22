using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Domain.ValueObjects
{
    /// <summary>
    /// 文件地址
    /// </summary>
    public class FileAddress
    {
        /// <summary>
        /// 访问地址
        /// </summary>
        public string? Access { get; set; }
        /// <summary>
        /// 备份地址
        /// </summary>
        public string? Backup { get; set; }
    }
}
