using System.ComponentModel.DataAnnotations;

namespace GoatlyCore.ViewModels
{
    public class StatusCodeViewModel
    {
        [Display(Name = "HTTP response code:")]
        public int Code { get; set; }
        [Display(Name = "Message:")]
        public string Message { get; set; } = "";

        public static StatusCodeViewModel Create(ApiResponse response)
        {
            return new StatusCodeViewModel() { Code = response.StatusCode, Message = response.Message };
        }
    }
}
