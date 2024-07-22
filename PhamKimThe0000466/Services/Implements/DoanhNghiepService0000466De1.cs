using Microsoft.EntityFrameworkCore;
using PhamKimThe0000466.DbContexts;
using PhamKimThe0000466.Dtos;
using PhamKimThe0000466.Dtos.Comon;
using PhamKimThe0000466.Entities;
using PhamKimThe0000466.Migrations;
using PhamKimThe0000466.Services.Interfaces;

namespace PhamKimThe0000466.Services.Implements
{
    public class DoanhNghiepService0000466De1 : IDoanhNghiepService0000466De1
    {
        private readonly MyDbContext0000466De1 _dbContext;

        public DoanhNghiepService0000466De1(MyDbContext0000466De1 dbContext)
        {
            _dbContext = dbContext;
        }
        public DoanhNghiepDto0000466De1 Add(DoanhNghiepDto0000466De1 input)
        {
            var doanhNghiep = new DoanhNghiep0000466De1
            {
                TenDoanhNghiep = input.TenDoanhNghiep,
                MaSoThue = input.MaSoThue,
                DiaChi = input.DiaChi
            };
            _dbContext.DoanhNghieps.Add(doanhNghiep);
            _dbContext.SaveChanges();
            return input;
        }

        public void DeleteDoanhNghiep(int id)
        {
            if(_dbContext.DoanhNghieps.Any(e=> e.DoanhNghiepId == id))
            {

            }
        }

        public DoanhNghiepDto0000466De1 Update(int id, DoanhNghiepDto0000466De1 input)
        {
            var doanhNghiep = _dbContext.DoanhNghieps.SingleOrDefault(d => d.DoanhNghiepId == id);
            if (doanhNghiep == null)
            {
                throw new Exception("khong tim thay doanh nghiep");
            }
            doanhNghiep.TenDoanhNghiep = input.TenDoanhNghiep;
            doanhNghiep.MaSoThue = input.MaSoThue;
            doanhNghiep.DiaChi = input.DiaChi;

            _dbContext.SaveChanges();
            return input;
        }
        public void Delete(int id)
        {
            var delete = _dbContext.DoanhNghieps.Find(id);
            if (delete == null)
            {
                throw new Exception("Khong tim thay doanh nghiep");
            }
            _dbContext.DoanhNghieps.Remove(delete);
            _dbContext.SaveChanges();
        }
        public IEnumerable<DoanhNghiepDto0000466De1> GetAll(Filter0000466De1 input)
        {
            var query = _dbContext.DoanhNghieps.AsQueryable();
            if (!string.IsNullOrWhiteSpace(input.Keyword))
            {
                string keyword = input.Keyword.Trim().ToLower();
                query = query.Where(d => d.TenDoanhNghiep.ToLower().Contains(keyword) || d.MaSoThue.ToLower().Contains(keyword));
            }
            query = query.Skip((input.PageIndex - 1) * input.PageSize).Take(input.PageSize);
            return query.Select(d => new DoanhNghiepDto0000466De1
            {
                DoanhNghiepId = d.DoanhNghiepId,
                TenDoanhNghiep = d.TenDoanhNghiep,
                MaSoThue = d.MaSoThue,
                DiaChi = d.DiaChi
            }).ToList();
        }
    }
}
