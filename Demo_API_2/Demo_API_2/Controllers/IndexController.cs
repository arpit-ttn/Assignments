using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Demo_API_2.Data;
using Demo_API_2.Models;

namespace Demo_API_2.Controllers
{
    public class IndexController : ApiController
    {
        Data.Demo_Class demo_Class = new Data.Demo_Class();
        Models.Model_Class model_Class = new Models.Model_Class();
        [HttpGet]
        public IHttpActionResult GetData()
        {
            
            DataSet ds = demo_Class.GetData();
            return Ok(ds);
        }
        [HttpGet]
        public IHttpActionResult GetData(int id)
        {
            
            DataSet ds = demo_Class.GetData(id);
            return Ok(ds);
        }
        [HttpPost]
        public IHttpActionResult InsertData(Models.Model_Class model_Class)
        {
            try
            {
                if (model_Class == null)
                {
                    return Ok(BadRequest());
                }

                bool result = demo_Class.InsertData(model_Class);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = " unable to insert data" });
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        [HttpPut]
        public IHttpActionResult UpdateData(int id, [FromBody]Models.Model_Class model_Class)
        {
            //Student student = new Student();
            try
            {
                if (model_Class == null)
                {
                    return Ok(BadRequest());
                }
                bool result = demo_Class.UpdateData(id, model_Class);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "unable to update data" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        [HttpDelete]
        public IHttpActionResult DeleteData(int id)
        {

            try
            {
                if (demo_Class == null)
                {
                    return Ok(BadRequest());
                }
                bool result = demo_Class.DeleteData(id);
                if (result)
                {
                    return Ok(new { Status = true });
                }
                else
                {
                    return Ok(new { Status = false, description = "Something went wrong" });
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
