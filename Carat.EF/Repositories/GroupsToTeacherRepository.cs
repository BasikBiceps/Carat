﻿using System;
using System.Collections.Generic;
using Carat.Data.Entities;
using Carat.Data.Repositories;
using System.Linq;

namespace Carat.EF.Repositories
{
    public class GroupsToTeacherRepository : IGroupsToTeacherRepository
    {
        private string m_dbPath = "";

        public GroupsToTeacherRepository(string dbPath)
        {
            m_dbPath = dbPath;
        }

        public List<GroupsToTeacher> GetAllGroupsToTeachers()
        {
            using (var ctx = new CaratDbContext(m_dbPath))
            {
                return ctx.GroupsToTeachers.ToList();
            }
        }
        public GroupsToTeacher GetGroupsToTeacher(int groupsToTeacherId)
        {
            using (var ctx = new CaratDbContext(m_dbPath))
            {
                return ctx.GroupsToTeachers.Where(b => b.Id == groupsToTeacherId).FirstOrDefault();
            }
        }

        public void AddGroupsToTeacher(GroupsToTeacher groupsToTeacher)
        {
            using (var ctx = new CaratDbContext(m_dbPath))
            {
                ctx.Add(groupsToTeacher);
                ctx.SaveChanges();
            }
        }

        public void RemoveGroupsToTeacher(GroupsToTeacher groupsToTeacher)
        {
            using (var ctx = new CaratDbContext(m_dbPath))
            {
                ctx.Remove(groupsToTeacher);
                ctx.SaveChanges();
            }
        }

        public void UpdateGroupsToTeacher(GroupsToTeacher groupsToTeacher)
        {
            using (var ctx = new CaratDbContext(m_dbPath))
            {
                ctx.Update(groupsToTeacher);
                ctx.SaveChanges();
            }
        }

        public void DeleteAllGroupsToTeachers()
        {
            using (var ctx = new CaratDbContext(m_dbPath))
            {
                ctx.RemoveRange(GetAllGroupsToTeachers());
                ctx.SaveChanges();
            }
        }
    }
}
