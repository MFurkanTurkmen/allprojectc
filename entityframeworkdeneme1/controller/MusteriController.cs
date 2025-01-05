

using DBConnectProject.entity;
using entityframeworkdeneme1.service;

namespace DBConnectProject.controller
{
    internal class MusteriController
    {
        private IMusteriService musteriService;
        public MusteriController(IMusteriService musteriService)
        {
            this.musteriService = musteriService;
        }

        public void save(Musteri musteri)
        {
            musteriService.save(musteri);
        }

        public Musteri getMusteriByEmail(string email)
        {
            return musteriService.getMusteriByEmail(email);
        }


    }
}
