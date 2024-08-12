using business_logic.DTOs;

namespace business_logic.Interfaces
{
    public interface IVideoService
    {
        public Task<IEnumerable<VideoDto>> Get(IEnumerable<int> ids);
        public IEnumerable<VideoDto> GetAll();
        public Task<VideoDto> Get(int id);
        public void Create(CreateVideoModel videoModel);
        public Task Edit(VideoDto videoDto);
        public Task Delete(int id);
    }
}