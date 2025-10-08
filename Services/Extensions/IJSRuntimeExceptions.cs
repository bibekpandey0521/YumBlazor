using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.JSInterop;

namespace YumBlazor.Services.Extensions
{
    public static class IJSRuntimeExceptions
    {
        public static async Task ToastrSuccess(this IJSRuntime js,string message)
        {
            await js.InvokeVoidAsync("ShowToastr","success", message);
        }
        public static async Task ToastError(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("ShowToastr", "error" , message);
        }
    }
}
