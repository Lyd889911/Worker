using BlazorComponent;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace Worker.Blazor.Wasm.Pages.Logins
{
    public partial class LoginBase
    {
        private bool _show;

        [Inject]
        public NavigationManager Navigation { get; set; } = default!;

        [Parameter]
        public bool HideLogo { get; set; }

        [Parameter]
        public double Width { get; set; } = 410;

        [Parameter]
        public StringNumber? Elevation { get; set; }

        [Parameter]
        public string CreateAccountRoute { get; set; } = $"pages/authentication/register-v1";

        [Parameter]
        public string ForgotPasswordRoute { get; set; } = $"pages/authentication/forgot-password-v1";

        [Parameter]
        public EventCallback<MouseEventArgs> OnLogin { get; set; }
    }
}
