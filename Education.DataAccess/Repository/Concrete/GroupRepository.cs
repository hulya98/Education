using Education.DataAccess.Services.Abstract;
using Education.DataAccess.UnitOfWork;
using System.Text.RegularExpressions;

namespace Education.DataAccess.Services.Concrete
{
    public class GroupRepository : IGroupRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public GroupRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Group> CreateAsync(Group item)
        {
            return await _unitOfWork.Groups.CreateAsync(item);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            return await _unitOfWork.Groups.DeleteAsync(id);
        }

        public Task<IEnumerable<Group>> GetAllAsync()
        {
            return _unitOfWork.Groups.GetAllAsync();
        }

        public Task<Group> GetById(int id)
        {
            return _unitOfWork.Groups.GetById(id);
        }

        public Task<Group> UpdateAsync(Group item)
        {
            throw new NotImplementedException();
        }
    }
}
