using AutoMapper;
using business_logic.DTOs;
using business_logic.Entities;
using business_logic.Interfaces;
using business_logic.Specifications;
using System.Net;

namespace business_logic.Services;

public class LikeService : ILikeService
{
    public readonly IMapper mapper;
    public readonly IRepository<Like> likeR;
    public LikeService(IMapper mapper,
                       IRepository<Like> likeR)
    {
        this.mapper = mapper;
        this.likeR = likeR; 
    }
    public void Add(CreateLikeModel likeModel)
    {
        likeR.Insert(mapper.Map<Like>(likeModel));
        likeR.Save();
    }
    async Task<IEnumerable<VideoDto>> ILikeService.Get(string userId)
    {
        return (IEnumerable<VideoDto>)mapper.Map<List<LikeDto>>(await likeR.GetListBySpec(new LikeSpecs.ById(userId)));
    }
    public async Task Remove(string userId)
    {
        if (userId == "") throw new HttpException(Errors.ItemNotFound, HttpStatusCode.BadRequest);

        var video = likeR.GetById(userId) ?? throw new HttpException(Errors.ItemNotFound, HttpStatusCode.NotFound);
        likeR.Delete(video);
        likeR.Save();
    }

}