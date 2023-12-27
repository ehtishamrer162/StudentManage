    using System;
    using System.Collections.Generic;

    namespace StudentManage.Models;

    public partial class Classtbl
    {
        public int CId { get; set; }

        public string Name { get; set; } = null!;

        public int RoomNumber { get; set; }

        public int Fid { get; set; }
       
        public virtual ICollection<Enrolled> Enrolleds { get; set; }
    }
