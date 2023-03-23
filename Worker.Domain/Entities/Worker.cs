using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Worker.Domain.ValueObjects;
using Worker.Shared.BaseEntities;
using Worker.Shared.Enums;

namespace Worker.Domain.Entities
{
    public class Worker:AggregateRoot
    {
        #region 属性
        public string? Name { get; set; }
        public WorkerState State { get; set; }
        public Gender Gender { get; set; }
        public Salary? Salary { get;private set; }
        public DateTime Hiredate { get; set; }
        public string? Phone { get;private set; }
        public string? IDCard { get;private set; }
        public Bank? Bank { get; private set; }
        public Guid? DepartmentId { get;private set; }
        public Guid? PostitionId { get;private set; }
        public Guid? AvatarId { get;private set; }

        public List<Clockin>? Clockins { get; set; }
        public WorkerClockinStatistics? ClockinStatistics { get; set; }
        public List<WorkerHistoryFile>? HistoryFiles { get; set; }
        #endregion

        #region 实体方法
        private Worker()
        {

        }
        internal Worker(string? name, WorkerState state, Gender gender, DateTime hiredate,
            Department department, Position position,FileItem fileItem,Guid CreatorId):base(CreatorId)
        {
            Name = name;
            State = state;
            Gender = gender;
            Salary = position.Salary;
            Hiredate = hiredate;
            DepartmentId = department.Id;
            PostitionId = position.Id;
            //头像必须传，没有头像就用默认头像
            AvatarId = fileItem.Id;
            Clockins = new List<Clockin>();
            HistoryFiles = new List<WorkerHistoryFile>();
            ClockinStatistics = new WorkerClockinStatistics(this,CreatorId);
            //添加了头像，就要添加历史文件
            HistoryFiles.Add(new WorkerHistoryFile(this, fileItem, CreatorId));
        }
        /// <summary>
        /// 设置薪资
        /// </summary>
        /// <param name="salary"></param>
        public void SetSalary(Salary salary)
        {
            Salary = salary;
        }
        /// <summary>
        /// 设置手机
        /// </summary>
        /// <param name="phone"></param>
        public void SetPhone(string phone)
        {
            Phone = phone;
        }
        /// <summary>
        /// 设置身份证
        /// </summary>
        /// <param name="idcard"></param>
        public void SetIDCard(string idcard)
        {
            IDCard = idcard;
        }
        /// <summary>
        /// 设置银行
        /// </summary>
        /// <param name="bank"></param>
        public void SetBank(Bank bank)
        {
            Bank = bank;
        }
        /// <summary>
        /// 添加头像
        /// </summary>
        /// <param name="fileItem"></param>
        public void SetAvatar(FileItem fileItem)
        {
            AvatarId = fileItem.Id;
            CreateHistoryFile(fileItem);
        }
        /// <summary>
        /// 设置职位
        /// </summary>
        /// <param name="position"></param>
        public void SetPostition(Position position)
        {
            PostitionId = position.Id;
        }
        /// <summary>
        /// 添加历史文件
        /// </summary>
        /// <param name="fileItem"></param>
        public void CreateHistoryFile(FileItem fileItem)
        {
            HistoryFiles.Add(new WorkerHistoryFile(this,fileItem,CreatorId));
        }
        #endregion

    }
}
