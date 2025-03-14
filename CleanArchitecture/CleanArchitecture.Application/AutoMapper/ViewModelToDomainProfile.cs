using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.AutoMapper
{
    public class ViewModelToDomainProfile: Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name,c.Description,c.ImageUrl));
        }
    }
}
