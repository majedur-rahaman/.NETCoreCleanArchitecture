using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Commands;
using CleanArchitecture.Domain.Core.Bus;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseReporsitory;
        private readonly IMediatorHandler _bus;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus)
        {
            _courseReporsitory = courseRepository;
            _bus = bus;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            var createCourseCommand = new CreateCourseCommand(
                    courseViewModel.Name,
                    courseViewModel.Description,
                    courseViewModel.ImageUrl
                );
            _bus.SendCommand(createCourseCommand);
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseReporsitory.GetCourses(),
            }; 
        }
    }
}
