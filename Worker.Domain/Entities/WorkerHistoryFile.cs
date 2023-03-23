using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Shared.BaseEntities;
using Worker.Shared.BaseEntities.Contract;

namespace Worker.Domain.Entities
{
    /// <summary>
    /// 工人的历史文件
    /// </summary>
    public class WorkerHistoryFile : Entity, IHasCreationCreator
    {
        public Guid? CreatorId { get; set; }
        public DateTime CreationTime { get; set; }
        public Guid WorkerId { get; set; }
        public Worker? Worker { get; set; }
        public Guid FileId { get; set; }
        public WorkerHistoryFile(Worker worker,FileItem fileItem,Guid? CreatorId)
        {
            Worker = worker;
            WorkerId=worker.Id;
            FileId = fileItem.Id;
            this.CreatorId = CreatorId;
            this.CreationTime=DateTime.Now;
        }
    }
}
