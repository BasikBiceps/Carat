﻿using System.Collections.Generic;
using Carat.Data.Entities;

namespace Carat.Data.Repositories
{
    public interface ITeacherRepository
    {
        List<Teacher> GetAllTeachers();
        Teacher GetTeacher(int teacherId);
        Teacher GetTeacherByName(string name);
        void AddTeacher(Teacher teacher);
        void AddTeachers(List<Teacher> teachers);
        void RemoveTeacher(Teacher teacher);
        void UpdateTeacher(Teacher teacher);
        void DeleteAllTeachers();
    }
}
