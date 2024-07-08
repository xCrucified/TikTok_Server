using Microsoft.AspNetCore.Http;

namespace Bussiness_Logic.DTOs
{
    public class CreateVideoModel
    {
        string Title { get; set; }
        public int Views { get; set; }
        public bool IsPrivate { get; set; }
        public required IFormFile VideoUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public string UserId { get; set; }
    }   
}
