using Education.DataAccess.Services.Abstract;
using Education.DataAccess.Services.Concrete;

namespace Education.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        private IGroupRepository _groups;
        public UnitOfWork(Context context)
        {
            _context = context;
        }
        public IGroupRepository Groups
        {
            get
            {
                if (_groups == null)
                {
                    _groups = new GroupRepository(this);
                }
                return _groups;
            }
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
