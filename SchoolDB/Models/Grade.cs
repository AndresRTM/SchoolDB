using System;
using System.Collections.Generic;

namespace SchoolDB.Models;

public partial class Grade
{
    public int GradeId { get; set; }

    public string? Grade1 { get; set; }

    public DateOnly GradeDate { get; set; }

    public int? FkstaffId { get; set; }

    public int? FkstudentId { get; set; }

    public int? FkcourseId { get; set; }

    public virtual Course? Fkcourse { get; set; }

    public virtual Staff? Fkstaff { get; set; }

    public virtual Student? Fkstudent { get; set; }
}
