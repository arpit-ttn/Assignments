using Entity_CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Entity_CodeFirst.Controllers
{
    public class IndexController : ApiController
    {
        //We have written the insert method first because there is no entry present in the database.
        [HttpPost]
        public IHttpActionResult Insert(Customer customer) 
        {                                                 
            var context = new SalesContext();
            try
            {

                context.Customer.Add(customer);
                context.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return Ok("Data Inserted.");
        }

        //Now we use get method to see our data.
        [HttpGet]
        public IHttpActionResult Get()
        {                                      
            try
            {
                var context = new SalesContext();
                var result = from s in context.Customer
                             join o in context.Orders on s.CustomerId equals o.CustomerId
                             select new
                             {
                                 Customerid = s.CustomerId,
                                 firstName = s.FirstName,
                                 secondName = s.SecondName,
                                 Address = s.Address,
                                 orderId = o.OrderId
                             };
                return Ok(result);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // From this method we will be able to see the data of any particular customer ID.
        [HttpGet]
        public IHttpActionResult GetById(int Id)
        {
            try
            {
                var context = new SalesContext();
                var list = context.Customer.Where(c => c.CustomerId == Id).Include(s => s.Orders).ThenInclude(s => s.Product).FirstOrDefault();
                return Ok(list);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //This method will update the orders table according to their customer ID
        [HttpPut]
        public IHttpActionResult Update(int Id, Orders order)
        {
            var context = new SalesContext();
            try
            {
                var std = context.Orders.FirstOrDefault(s => s.CustomerId == Id); 
                std.Quantity = order.Quantity;                                 
                context.SaveChanges();
                return Ok("Row Updated");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // This method will accepts the CustomerId as parameter and will delete the order and the customer accordingly.
        [HttpDelete]
        public IHttpActionResult DeleteOrderAndCustomer(int Id) 
        {
            try
            {
                using (var context = new SalesContext())
                {
                    var std1 = context.Orders.FirstOrDefault(q => q.CustomerId == Id);
                    context.Orders.Remove(std1);
                    var std = context.Customer.FirstOrDefault(s => s.CustomerId == Id);
                    context.Customer.Remove(std);
                    context.SaveChanges();

                }
                return Ok("Data Deleted");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
