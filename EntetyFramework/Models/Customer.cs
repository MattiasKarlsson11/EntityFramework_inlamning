using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Models
{
    [Index(nameof(PhoneNumber), Name = "UQ__Customer__85FB4E38A19A62C9", IsUnique = true)]
    [Index(nameof(Email), Name = "UQ__Customer__A9D1053401B523C9", IsUnique = true)]
    public partial class Customer
    {
        public Customer()
        {
            Errands = new HashSet<Errand>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [StringLength(50)]
        public string Email { get; set; } = null!;
        [StringLength(10)]
        [Unicode(false)]
        public string PhoneNumber { get; set; } = null!;
        [StringLength(5)]
        [Unicode(false)]
        public string PostalCode { get; set; } = null!;
        [StringLength(50)]
        public string AdressName { get; set; } = null!;
        [StringLength(50)]
        public string City { get; set; } = null!;
        [StringLength(50)]
        public string Country { get; set; } = null!;

        [InverseProperty(nameof(Errand.Customer))]
        public virtual ICollection<Errand> Errands { get; set; }
        public string CustomerFullName => $"{FirstName} {LastName}";
    }
}
