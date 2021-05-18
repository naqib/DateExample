using QM.Domain.Model;

namespace QM.Business.Repository.Interface
{
    public interface IDateRepository
    {
        int GetDifference(Date date1, Date date2);
    }
}
