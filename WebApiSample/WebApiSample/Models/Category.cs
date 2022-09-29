using System.Collections.Generic;

namespace WebApiSample.Models;

public class Category
{
    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public string? Description { get; set; }

    public virtual ICollection<Product>? Products { get; set; }
}


public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public virtual ICollection<StudentsCources>? Cources { get; set; }
}

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public virtual ICollection<StudentsCources>? Students { get; set; }
}


public class StudentsCources
{
    public int StudentId { get; set; }
    public Student Student { get; set; }
    public int CourseId { get; set; }
    public Course Course { get; set; }
}