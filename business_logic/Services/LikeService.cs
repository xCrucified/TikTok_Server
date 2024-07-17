using AutoMapper;
using business_logic.DTOs;
using business_logic.Entities;
using business_logic.Interfaces;
using business_logic.Specifications;

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

    public async Task<IEnumerable<LikeDto>> Get(string id)
    {
        return mapper.Map<List<LikeDto>>(await likeR.GetListBySpec(new LikeSpecs.ById(Convert.ToInt32(id))));
    }

    public Task Remove(string userId)
    {
        throw new NotImplementedException();
    }
}