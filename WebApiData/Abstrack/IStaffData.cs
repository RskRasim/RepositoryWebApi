using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiData.Abstrack
{
   public interface IStaffData
    {
        int Delete(int Id, int CompanyId);
        int Post(Staff staff);
        Staff Put(Staff staff);
        IEnumerable<Staff> GetAll();
        Staff Get(int Id, int CompanyId);

    }
}
