using System;
using System.Collections.Generic;

namespace StudentManage.Models;

public partial class Student
{
    public int Sid { get; set; }

    public string Sname { get; set; } = null!;

    public string Smajor { get; set; } = null!;

    public string Sstanding { get; set; } = null!;
    public virtual ICollection<Enrolled> Enrolleds { get; set; }
}
