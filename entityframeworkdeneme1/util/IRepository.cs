namespace DBConnectProject.util
{
    internal interface IRepository<T, ID>
    {

        List<T> GetAll();
        void add(T x);
        void remove(T x);

        T getById(ID id);


    }
}
