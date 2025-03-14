using AutoMapper;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.AutoMapper
{
    public class DomainToViewModelProfile: Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
