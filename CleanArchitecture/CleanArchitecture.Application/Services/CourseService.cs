using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.ViewModels;
using CleanArchitecture.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseReporsitory;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseReporsitory = courseRepository;
        }
        public CourseViewModel GetCourse()
        {
            return new CourseViewModel()
            {
                Courses = _courseReporsitory.GetCourses(),
            }; 
        }
    }
}
