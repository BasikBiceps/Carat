﻿namespace Carat.Data.Entities
{
    public class CurriculumItem
    {
        public int Id { get; set; }
        public int Course { get; set; }
        public int SubjectId { get; set; }
        public double SubjectHours { get; set; }
        public double WorkTypeHours { get; set; }
    }
}
