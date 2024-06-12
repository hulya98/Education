using Education.DataAccess.Services.Abstract;

namespace Education.DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> CompleteAsync();
        public IGroupRepository Groups { get; }
    }
}
