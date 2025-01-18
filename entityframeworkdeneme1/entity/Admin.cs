using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBConnectProject.entity;

namespace entityframeworkdeneme1.entity
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }

        [Required]
        [StringLength(50)]
        public string username { get; set; }

        [Required]
        [StringLength(100)]
        public string password { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string email { get; set; }

        [ForeignKey("RoleId")]
        public Role role { get; set; }
    }
}
