using System;
using System.Collections.Generic;

namespace StudentManage.Models;

public partial class Faculty
{
    public int Fid { get; set; }

    public string Fname { get; set; } = null!;

    public int Deptid { get; set; }

    public string Standing { get; set; } = null!;
    public virtual ICollection<Enrolled> Enrolleds { get; set; }
}
