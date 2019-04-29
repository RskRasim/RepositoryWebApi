using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiData;

namespace WebApiBll.Abstrack
{
   public interface IStaffBll
    {
        bool Delete(int Id, int CompanyId);
        bool Post(Staff staff);
        Staff Put(Staff staff);
        IEnumerable<Staff> GetAll();
        Staff Get(int Id, int CompanyId);

    }
}
