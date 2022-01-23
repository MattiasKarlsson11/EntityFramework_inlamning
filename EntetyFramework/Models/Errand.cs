using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models
{
    public partial class Errand
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string ErrandTitel { get; set; } = null!;
        [StringLength(150)]
        public string ErrandSpecipication { get; set; } = null!;
        public DateTime ErrandTime { get; set; }
        [StringLength(50)]
        public string ErrandStatus { get; set; } = null!;
        public int CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty("Errands")]
        public virtual Customer Customer { get; set; } = null!;
    }
}
