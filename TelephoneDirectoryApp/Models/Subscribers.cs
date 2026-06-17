namespace TelephoneDirectoryApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Subscribers
    {
        [Key]
        public int IdSubscriber { get; set; }

        [Required]
        [StringLength(300)]
        public string Fio { get; set; }

        public int PositionId { get; set; }

        public int DepartmentId { get; set; }

        public int BuildingId { get; set; }

        public int OfficeId { get; set; }

        [StringLength(50)]
        public string WorkPhoneNumber { get; set; }

        [StringLength(50)]
        public string PersonalPhoneNumber { get; set; }

        [StringLength(50)]
        public string EmailAdress { get; set; }

        public int? UserId { get; set; }

        public virtual Buildings Buildings { get; set; }

        public virtual Departments Departments { get; set; }

        public virtual Offices Offices { get; set; }

        public virtual Positions Positions { get; set; }

        public virtual Users Users { get; set; }
    }
}
