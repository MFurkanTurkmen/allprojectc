

namespace DBConnectProject.entity
{
    internal class Musteri
    {
        /*    
         *    id bigint primary key IDENTITY (1,1),
    name varchar(255),
    surname varchar(255),
    email varchar(255),
    password varchar(255),
    role bigint foreign key references Role(id)
        */

        public long id{ get; set; }
        public string name{ get; set; }
        public string surname { get; set; }

        public string email { get; set; }

        public string password { get; set; }

        public Role role { get; set; }


    }
}
