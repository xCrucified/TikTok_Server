using AutoMapper;
using Bussiness_Logic.DTOs;
using Bussiness_Logic.Entities;
using Bussiness_Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness_Logic.Profiles
{
    internal class ApplicationProfile : Profile
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
