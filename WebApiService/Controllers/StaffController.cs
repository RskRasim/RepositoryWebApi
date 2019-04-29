using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiBll;
using WebApiData;

namespace WebApiService.Controllers
{
    public class StaffController : ApiController
    {
        /* sadece json istekte bulunmalısınız foreign key döngüleri json için ayarlanmış durumda xml  foreign keylerden dolayı hata vericektir */
        private StaffManager _staffManager;
        public StaffController()
        {
            _staffManager = new StaffManager();
        }

        public HttpResponseMessage Get(int Id, int CompanyId)
        {
            try
            {
                Staff staff = _staffManager.Get(Id, CompanyId);
                if (staff != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, staff);
                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Hiç bir sonuç bulunamadı");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "bir hata oluştu");

            }

        }
        [HttpGet]
        [Route("Staff/GetAll")]
        public HttpResponseMessage Get()
        {
            try
            {
                IEnumerable<Staff> allsttaff = _staffManager.GetAll();
                if (allsttaff != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, allsttaff);

                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Hiç bir sonuç bulunamadı");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }

        }
        [HttpPost]
        [Route("Staff/Add")]
        public HttpResponseMessage Post(Staff staff)
        {
            try
            {
                if (_staffManager.Post(staff))
                {
                    return Request.CreateResponse(HttpStatusCode.Created, staff);

                }
                else
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "İşlem Gerçekleştirilemedi");
                }
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [Route("Staff/Update")]
        public HttpResponseMessage Put(Staff staff)
        {
            try
            {
                Staff staffup = _staffManager.Put(staff);

                return Request.CreateResponse(HttpStatusCode.OK, staffup);
            }
            catch (Exception ex)
            {

                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
