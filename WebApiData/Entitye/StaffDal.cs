using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiData.Abstrack;

namespace WebApiData.Entitye
{
    public class StaffDal : IStaffData
    {//Crud Staff
       private WebApiDbContext dbContext;
        public StaffDal()
        {
            dbContext = new WebApiDbContext();
        }

        public int Delete(int Id, int CompanyId)
        {
            dbContext.Staffs.Remove(dbContext.Staffs.FirstOrDefault(s => s.Id == Id && s.CompanyId == CompanyId));
            return dbContext.SaveChanges();
        }

        public Staff Get(int Id, int CompanyId)
        {
            return dbContext.Staffs.FirstOrDefault(s => s.Id == Id && s.CompanyId == CompanyId);
        }

        public IEnumerable<Staff> GetAll()
        {
            return dbContext.Staffs.ToList();
        }

        public int Post(Staff staff)
        {
            dbContext.Staffs.Add(staff);
            return dbContext.SaveChanges();
        }

        public Staff Put(Staff staff)
        {
         Staff staffUp =  dbContext.Staffs.FirstOrDefault(s => s.Id == staff.Id && s.CompanyId == staff.CompanyId);

            staffUp.Name = staff.Name;
            staffUp.Surname = staff.Surname;
            staffUp.Phone = staff.Phone;
            staffUp.Task = staff.Task;
            staffUp.Username = staff.Username;
            staffUp.Department = staff.Department;
            staffUp.Email = staff.Email;
            dbContext.SaveChanges();


            Staff staffUpOk = dbContext.Staffs.FirstOrDefault(s => s.Id == staff.Id && s.CompanyId == staff.CompanyId);
            return staffUpOk;

        }
    }
}
