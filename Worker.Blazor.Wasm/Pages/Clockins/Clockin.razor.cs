namespace Worker.Blazor.Wasm.Pages.Clockins
{
    public partial class Clockin
    {
        protected bool _menu2;
        protected DateOnly _date = DateOnly.FromDateTime(DateTime.Now);
        public class Department
        {
            public string Id { get; set; }
            public string DepartName { get; set; }
        }
        protected string _select = "全部部门";
        protected Department _selected = new Department()
        {
            DepartName = "全部部门",
            Id="0"
        };
        protected List<Department> _states = new List<Department>
        {
            new Department
            {
                DepartName="全部部门",
                Id="0"
            },
            new Department
            {
                DepartName="1号部门",
                Id="1"
            },
            new Department
            {
                DepartName="2号部门",
                Id="2"
            },
            new Department
            {
                DepartName="3号部门",
                Id="3"
            },
            new Department
            {
                DepartName="4号部门",
                Id="4"
            },
            new Department
            {
                DepartName="5号部门",
                Id="5"
            }
        };
        protected string GetWeek(DayOfWeek dw)
        {
            switch (dw.ToString())
            {
                case "Sunday":return "周日";
                case "Monday":return "周一";
                case "Tuesday":return "周二";
                case "Wednesday":return "周三";
                case "Thursday":return "周四";
                case "Friday":return "周五";
                case "Saturday":return "周六";
                default:return "";
            }
        }
    }
}
