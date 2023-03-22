using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Shared.Enums
{
    /// <summary>
    /// 工人状态
    /// </summary>
    public enum WorkerState
    {
        /// <summary>
        /// 在职
        /// </summary>
        Working,
        /// <summary>
        /// 离职
        /// </summary>
        Leaving,
        /// <summary>
        /// 请假中
        /// </summary>
        Vacationing

    }
}
