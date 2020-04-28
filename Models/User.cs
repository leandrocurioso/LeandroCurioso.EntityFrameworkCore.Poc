using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeandroCurioso.EntityFrameworkCore.Poc.Models
{
    [Table("user")]
    [Serializable]
    public class User : Entity
    {
        [Required]
        [Column("name", TypeName = "varchar(200)")]
        public string Name { get; set; }

        [Required]
        [Column("email", TypeName = "varchar(200)")]
        public string Email { get; set; }
    }
}
