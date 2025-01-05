

using DBConnectProject.entity;
using DBConnectProject.repository;
using entityframeworkdeneme1.service;

namespace DBConnectProject.service
{
    internal class MusteriService : IMusteriService
    {
        private IMusteriRepository _repository;
        public MusteriService(IMusteriRepository repository)
        {
            _repository = repository;
        }

        public void save(Musteri musteri)
        {
            _repository.add(musteri);
        }


        public Musteri getMusteriByEmail(string email)
        {
            return _repository.getMusteriByEmail(email);
        }


    }
}
