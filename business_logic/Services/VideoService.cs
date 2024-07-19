using AutoMapper;
using business_logic.DTOs;
using business_logic.Entities;
using business_logic.Interfaces;
using business_logic.Specifications;
using System.Net;

namespace business_logic.Services
{
    public class VideoService : IVideoService
    {
        private readonly IMapper mapper;
        private readonly IRepository<Video> videoR;

        public VideoService(IMapper mapper,
                               IRepository<Video> videoR)
        {
            this.mapper = mapper;
            this.videoR = videoR;
        }
        public void Create(CreateVideoModel videoModel)
        {
            videoR.Insert(mapper.Map<Video>(videoModel));
            videoR.Save();
        }

        public async Task Delete(int id)
        {
            if (id < 0) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.BadRequest);

            var video = videoR.GetById(id);

            if (video == null) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.NotFound);

            videoR.Delete(video);
            videoR.Save();
        }
        
        public async Task Edit(VideoDto videoDto)
        {
            videoR.Update(mapper.Map<Video>(videoDto));
            videoR.Save();
        }

        async Task<IEnumerable<VideoDto>> IVideoService.Get(IEnumerable<int> ids)
        {
            return mapper.Map<List<VideoDto>>(await videoR.GetListBySpec(new VideoSpecs.ByIds(ids)));
        }

        public async Task<VideoDto> Get(int id)
        {
            if (id < 0) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.BadRequest);

            var item = await videoR.GetItemBySpec(new VideoSpecs.ById(id));
            if (item == null) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.NotFound);

            var dto = mapper.Map<VideoDto>(item);

            return dto;
        }

        public IEnumerable<VideoDto> GetAll()
        {
            return mapper.Map<List<VideoDto>>(videoR.GetAll());
        }
    }
}
