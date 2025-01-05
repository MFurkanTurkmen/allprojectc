using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBConnectProject.entity;
using DBConnectProject.util;

namespace entityframeworkdeneme1.service
{
    internal interface IMusteriService
    {
        public void save(Musteri musteri);



        public Musteri getMusteriByEmail(string email);
       

    }
}
