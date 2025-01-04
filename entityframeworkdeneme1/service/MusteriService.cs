

using DBConnectProject.repository;

namespace DBConnectProject.service
{
    internal class MusteriService
    {
        private IMusteriRepository _repository;
        public MusteriService(IMusteriRepository repository)
        {
            _repository = repository;
        }


    }
}
