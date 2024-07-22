using PhamKimThe0000466.Dtos;
using PhamKimThe0000466.Dtos.Comon;

namespace PhamKimThe0000466.Services.Interfaces
{
    public interface IDoanhNghiepService0000466De1
    {
        DoanhNghiepDto0000466De1 Add(DoanhNghiepDto0000466De1 input);
        DoanhNghiepDto0000466De1 Update(int id, DoanhNghiepDto0000466De1 input);

        void Delete(int id);
        IEnumerable<DoanhNghiepDto0000466De1> GetAll(Filter0000466De1 input);
    }
}
