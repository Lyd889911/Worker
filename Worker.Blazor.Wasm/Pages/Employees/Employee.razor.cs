using BlazorComponent;

namespace Worker.Blazor.Wasm.Pages.Employees
{
    public partial class Employee
    {
        private bool value;
        private string _name;
        private string _sex;
        private DateOnly _prevDate = DateOnly.FromDateTime(DateTime.Now);
        private DateOnly _date = DateOnly.FromDateTime(DateTime.Now);
        private bool _menu;
        private bool _modal;
        private bool _menu2;
        public class Model
        {
            public int Id { get; set; }
            public string State { get; set; }
            public string Abbr { get; set; }
        }
        private string _message1 = "";
        private string _select = "FL";
        private int _index = 1;
        private int _total = 50;
        private Model _selected = new Model()
        {
            State = "Florida",
            Abbr = "FL"
        };
        private List<Model> _states = new List<Model>
        {
            new Model
            {
                State="Florida",
                Abbr="FL",
                Id=1
            },
            new Model
            {
                State="Georgia",
                Abbr="GA",
                Id=2
            },
            new Model
            {
                State="Nebraska",
                Abbr="NE",
                Id=3
            },
            new Model
            {
                State="California",
                Abbr="CA",
                Id=4
            },
            new Model
            {
                State="New York",
                Abbr="NY",
                Id=5
            }
        };
        public record Worker
        {
            public string Name { get; set; }
            public string Sex { get; set; }
            public string Type { get; set; }
            public string Phone { get; set; }
            public string IDCard { get; set; }
            public string BankID { get; set; }
            public string BankName { get; set; }
            public decimal DaySalary { get; set; }
            public decimal HourSalary { get; set; }
        }
        private void EditItem(Worker worker)
        {
            Console.WriteLine(worker.ToString());
        }
        private void DeleteItem(Worker worker)
        {
            Console.WriteLine(worker.ToString());
        }
        private List<DataTableHeader<Worker>> _headers = new List<DataTableHeader<Worker>>
        {
           new ()
           {
            Text= "姓名",
            Align= DataTableHeaderAlign.Start,
            Sortable= false,
            Value= nameof(Worker.Name)
          },
          new (){ Text= "性别", Value= nameof(Worker.Sex)},
          new (){ Text= "工作种类", Value= nameof(Worker.Type)},
          new (){ Text= "电话", Value= nameof(Worker.Phone)},
          new (){ Text= "身份证", Value= nameof(Worker.IDCard)},
          new (){ Text= "银行卡号", Value= nameof(Worker.BankID) },
          new (){ Text= "开户银行", Value= nameof(Worker.BankName) },
          new (){ Text= "日薪/元", Value= nameof(Worker.DaySalary) },
          new (){ Text= "时薪/元", Value= nameof(Worker.HourSalary) },
          new (){ Text= "操作", Value= "actions",Sortable=false,Width="100px",Align=DataTableHeaderAlign.Center, }
        };

        private List<Worker> _workers = new List<Worker>
        {
           new Worker()
           {
               Name="张三",
               Sex="男",
               Type="木工",
               Phone="12345678901",
               IDCard="123456789012345678",
               BankID="1223234525657678",
               BankName="重庆渝中区第一人民银行",
               DaySalary=360.5m,
               HourSalary=35m
           }
        };
        private List<Worker> GetWorkers()
        {
            for (int i = 0; i < 50; i++)
            {
                Worker w = new Worker()
                {
                    Name = "张三" + i,
                    Sex = i % 2 == 0 ? "男" : "女",
                    Type = i % 3 == 0 ? "大工" : "小工",
                    Phone = "12345678901",
                    IDCard = "123456789012345678",
                    BankID = "1223234525657678",
                    BankName = "重庆渝中区第一人民银行",
                    DaySalary = 100 + i * 0,
                    HourSalary = i * 15
                };
                _workers.Add(w);
            }
            return _workers;
        }

        private async Task OnSave()
        {
            await Task.Delay(1000);

            value = false;
        }

        private void OnCancel()
        {
            value = false;
        }

        private void OnDelete()
        {
            value = false;
        }
        private void AddWorker()
        {
            value = true;
        }
    }
}
