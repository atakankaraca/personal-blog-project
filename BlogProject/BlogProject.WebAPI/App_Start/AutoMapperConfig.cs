using AutoMapper;
using BlogProject.Application.Model.DTO;
using BlogTemp.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogProject.WebAPI.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            Mapper.Initialize((config) =>
            {
                config.CreateMap<Article, ArticleVM>();

                config.CreateMap<Bio, BioVM>();
                config.CreateMap<Category, CategoryVM>();
                config.CreateMap<Project, ProjectVM>();

                config.CreateMap<User, UserVM>()
                .ForMember(x => x.Username, opt => opt.Ignore())
                .ForMember(x => x.Password, opt => opt.Ignore());
            });
        }
    }
}