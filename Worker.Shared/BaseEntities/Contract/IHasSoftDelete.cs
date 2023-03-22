using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker.Shared.BaseEntities.Contract
{
    public interface IHasSoftDelete
    {
        /// <summary>
        /// 是否删除
        /// </summary>
        bool IsDeleted { get; }
    }
}
