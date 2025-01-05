using System.ComponentModel.DataAnnotations;

namespace DBConnectProject.entity
{
    public class Role
    {
        [Key]
        public long id { get; set; }
        public string name { get; set; }
    }
}
