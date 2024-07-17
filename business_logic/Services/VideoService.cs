using business_logic.DTOs;
using business_logic.Interfaces;

namespace business_logic.Services
{
    public class VideoService : IVideoService
    {
        void IVideoService.Crete(CreateVideoModel videoModel)
        {
            throw new NotImplementedException();
        }

        Task IVideoService.Delete(int id)
        {
            throw new NotImplementedException(); 
        }

        Task IVideoService.Edit(VideoDto videoDto)
        {
            throw new NotImplementedException();
        }

        Task<IEnumerable<VideoDto>> IVideoService.Get(IEnumerable<int> ids)
        {
            throw new NotImplementedException();
        }

        Task<VideoDto> IVideoService.Get(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<VideoDto> IVideoService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
