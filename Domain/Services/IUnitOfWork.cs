namespace Domain
{
    public interface IUnitOfWork
    {
        bool Commit();
        void Dispose();
    }
}