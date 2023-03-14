using Microsoft.AspNetCore.Components;

namespace Worker.Blazor.Wasm.Shared
{
    public partial class LydNavigation
    {
        public static bool _b=false;
        private Item[] _items = new Item[]
        {
         new Item{ Title= "数据看板", Icon= "mdi-view-dashboard" ,Path="/dashboard"},
         new Item { Title= "打卡签到", Icon= "mdi-image",Path="/clockin"},
         new Item { Title= "员工管理", Icon= "mdi-help-box",Path="/employee" },
         new Item { Title= "考勤查看", Icon= "mdi-help-box",Path="/workstatistics" },
         new Item { Title= "施工日志", Icon= "mdi-help-box",Path="/worklog" },
         new Item { Title= "文件管理", Icon= "mdi-help-box",Path="/file" },
         new Item { Title= "系统设置", Icon= "mdi-help-box",Path="/system" }
        };
    }
    class Item
    {
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Path { get; set; }
    }
}
