using BlazorComponent;
using Microsoft.AspNetCore.Components;

namespace Worker.Blazor.Wasm.Shared
{
    public partial class LydAppBar
    {
        string initials = "JD";
        string fullName = "John Doe";
        string email = "john.doe@doe.com";
        [Parameter]
        public Action ChangeDrawer { get; set; }
    }
}
