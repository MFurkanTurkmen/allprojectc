

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBConnectProject.entity
{
    public class Musteri
    {
        [Key]
        public long id{ get; set; }
        public string name{ get; set; }
        public string surname { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public Role role { get; set; }


    }
}
