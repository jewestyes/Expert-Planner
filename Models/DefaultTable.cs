﻿using System.ComponentModel.DataAnnotations;

namespace ExpertPlanner.Models
{
    public class DefaultTable
    {
        [Key]
        public int Id { get; set; }
        public string? FullName
        {
            get
            {
                return $"{LastName} {FirstName} {MiddleName}".Trim();
            }
        }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Link { get; set; }
        public string? Position { get; set; }
        public string? Monday { get; set; }
        public string? Tuesday { get; set; }
        public string? Wednesday { get; set; }
        public string? Thursday { get; set; }
        public string? Friday { get; set; }
        public string? Saturday { get; set; }
        public string? Sunday { get; set; }
    }
}
