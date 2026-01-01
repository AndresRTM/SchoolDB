using System;
using System.Collections.Generic;

namespace SchoolDB.Models;

public partial class Class
{
    public int ClassId { get; set; }

    public string ClassName { get; set; } = null!;

    public int FkstaffId { get; set; }

    public virtual Staff Fkstaff { get; set; } = null!;

    public virtual ICollection<Student> Students { get; set; } = new List<Student>();
}
