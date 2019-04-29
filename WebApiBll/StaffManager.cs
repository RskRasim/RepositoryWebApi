using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiBll.Abstrack;
using WebApiData;
using WebApiData.Entitye;

namespace WebApiBll
{
    public class StaffManager : IStaffBll
    {
        private  StaffDal _staffDal;
        public StaffManager()
        {
            _staffDal = new StaffDal();
        }
        public bool Delete(int Id, int CompanyId)
        {
            if (_staffDal.Delete(Id, CompanyId) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }    
        }
        public Staff Get(int Id, int CompanyId)
        {
            return _staffDal.Get(Id, CompanyId);
        }
        /*Company Id İle çalışan ayrı Methot yazılacak*/
        public IEnumerable<Staff> GetAll()
        {
            return _staffDal.GetAll();
        }

        public bool Post(Staff staff)
        {
           
            if (_staffDal.Post(staff) > 0)
            {
                return true;

            }

            else
            {
                return false;
            }
        }

        public Staff Put(Staff staff)
        {
            return _staffDal.Put(staff);
        }

      
    }
}
