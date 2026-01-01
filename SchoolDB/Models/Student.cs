using System;
using System.Collections.Generic;

namespace SchoolDB.Models;

public partial class Student
{
    public int StudentId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PersonalIdentityNumber { get; set; } = null!;

    public int? FkclassId { get; set; }

    public virtual Class? Fkclass { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();
}
