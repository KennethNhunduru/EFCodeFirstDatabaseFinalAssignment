﻿namespace EFCodeFirstDatabaseFinalAssignment.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? EmailAddress { get; set; }        
    }
}