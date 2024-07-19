using AutoMapper;
using business_logic.DTOs;
using business_logic.Entities;
using business_logic.Interfaces;
using business_logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business_logic.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile(IFileService fileService)
        {
            CreateMap<Video, VideoDto>();
            CreateMap<VideoDto, Video>();
            CreateMap<CreateVideoModel, Video>()
                .ForMember(x => x.VideoUrl, opt => opt.MapFrom(src => fileService.SaveVideo(src.VideoUrl).Result));
            CreateMap<CreateSaveModel, Save>();
            CreateMap<SaveDto, Save>();
            CreateMap<Save, SaveDto>();
            CreateMap<CreateLikeModel, Like>();
            CreateMap<LikeDto, Like>();
            CreateMap<Like, LikeDto>();
            CreateMap<CreateCommentModel, Comment>();
            CreateMap<CommentDto, Comment>();
            CreateMap<Comment, CommentDto>();
            CreateMap<RegisterModel, User>()
                .ForMember(x => x.AvatarPicture, opt => opt.MapFrom(src => fileService.SaveImage(src.AvatarPicture).Result));
        }
    }
}
