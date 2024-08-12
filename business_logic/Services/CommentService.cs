using AutoMapper;
using business_logic.DTOs;
using business_logic.Entities;
using business_logic.Interfaces;
using business_logic.Specifications;
using System.Net;

namespace business_logic.Services;

public class CommentService : ICommentService
{
    public readonly IMapper mapper;
    public readonly IRepository<Comment> commentR;
    public CommentService(IMapper mapper,
                          IRepository<Comment> commentR)
    {
        this.mapper = mapper;  
        this.commentR = commentR;
    }
    public void Add(CreateCommentModel commentModel)
    {
        commentR.Insert(mapper.Map<Comment>(commentModel));
        commentR.Save();
    }

    public async Task<IEnumerable<CommentDto>> Get(int id)
    {
        return mapper.Map<List<CommentDto>>(await commentR.GetListBySpec(new CommentSpecs.ById(id)));
    }

    public async Task Remove(int videoId)
    {
        if (videoId < 0) throw new HttpException(Errors.ItemNotFound, HttpStatusCode.BadRequest);

        var video = commentR.GetById(videoId) ?? throw new HttpException(Errors.ItemNotFound, HttpStatusCode.NotFound);
        commentR.Delete(video);
        commentR.Save();
    }
}