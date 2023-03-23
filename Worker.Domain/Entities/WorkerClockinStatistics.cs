using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Shared.BaseEntities;
using Worker.Shared.BaseEntities.Contract;

namespace Worker.Domain.Entities
{
    public class WorkerClockinStatistics:Entity,IHasCreationCreator,IHasModificationCreator,IHasDeleteCreator,IHasSoftDelete
    {
        /// <summary>
        /// 最后的打卡时间
        /// </summary>
        public DateTime? LastClockinTime { get; set; }
        /// <summary>
        /// 打卡的总共日期天数
        /// </summary>
        public int TotalClockinDate { get; set; }
        /// <summary>
        /// 总共上午打卡次数
        /// </summary>
        public int TotalMorning { get; set; }
        /// <summary>
        /// 总共下午打卡次数
        /// </summary>
        public int TotalAfternoon { get; set; }
        /// <summary>
        /// 总共全天打卡次数，（上午+下午)/2
        /// </summary>
        public decimal TotalClockinAllDay { get; set; }
        /// <summary>
        /// 总共加班时常
        /// </summary>
        public decimal TotalOvertime { get; set; }
        /// <summary>
        /// 总共获取薪资，每天上午0.5，下午0.5，加起来*当前日薪+当当天加班时长*时薪，最后全部天数加起来
        /// </summary>
        public decimal TotalSalary { get; set; }
        public Guid WorkerId { get; set; }
        public Worker? Worker { get; set; }
        public Guid? CreatorId{get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? ModificationTime { get; set; }
        public Guid? ModifierId { get; set; }
        public Guid? DeleteCreatorId { get; set; }
        public DateTime? DeleteTime { get; set; }
        public bool IsDeleted { get; set; }
        public WorkerClockinStatistics()
        {

        }
        public WorkerClockinStatistics(Worker worker,Guid? CreatorId)
        {
            Worker = worker;
            WorkerId = worker.Id;
            this.CreatorId = CreatorId;
            this.CreationTime=DateTime.Now;
            this.ModifierId = CreatorId;
            this.ModificationTime=DateTime.Now;
            LastClockinTime = null;
        }
    }
}
