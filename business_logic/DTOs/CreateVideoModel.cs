using Microsoft.AspNetCore.Http;

namespace business_logic.DTOs
{
    public class CreateVideoModel
    {
        public string Title { get; set; }
        public int Views { get; set; }
        public bool IsPrivate { get; set; }
        public IFormFile VideoUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public string UserId { get; set; }
    }   
}
