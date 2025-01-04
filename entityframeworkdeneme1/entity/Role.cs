using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnectProject.entity
{
    internal class Role
    {
        [Key]
        public long id { get; set; }
        public string name { get; set; }
    }
}
