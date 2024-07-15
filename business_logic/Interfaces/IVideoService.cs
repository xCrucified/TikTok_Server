using business_logic.DTOs;

namespace business_logic.Interfaces
{
    public interface IVideoService
    {
        Task<IEnumerable<VideoDto>> Get(IEnumerable<int> ids);
        IEnumerable<VideoDto> GetAll();
        Task<VideoDto> Get(int id);
        void Crete(CreateVideoModel videoModel);
        Task Edit(VideoDto videoDto);
        Task Delete(int id);
    }
}