namespace E_Jornal
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lectures
    {
        public int id { get; set; }

        public int Subject_Id { get; set; }

        public DateTime Date { get; set; }

        public int Studen_Id { get; set; }

        public int? Mark { get; set; }

        public virtual Students Students { get; set; }

        public virtual Subject Subject { get; set; }
    }
}
