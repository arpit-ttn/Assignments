using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entity_DBFirst.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Entity_DBFirst.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndexController : ControllerBase
    {

        // This method shows the data of all the customers with their respective order details.
        [HttpGet]
        public IActionResult Get()
        {
            var context = new DB_DataContext();
            try
            {
                //join operation between the customer and the orders table using include().
                var result = context.Customer.Include(x => x.Orders).ToList(); 
                return Ok(result);                                           
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        //This method will accept one parameter from the url as the "customer ID".
        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var context = new DB_DataContext();
            try
            {
                // linq query to perform join between three tables using include() and thenInclude().
                var list = context.Customer.Where(c => c.CustomerId == Id).Include(x => x.Orders).ThenInclude(x => x.Product).FirstOrDefault();
                return Ok(list); 
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        // This method is use to insert the values in the customer table as well as the orders table
        // and it will fetch the customer ID into order table automatically.
        [HttpPost]
        public IActionResult Insert(Customer customer)
        {

            try
            {
                var context = new DB_DataContext();
                context.Customer.Add(customer);
                context.SaveChanges();
                return Ok("Rows Inserted");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //This method will update the orders table according to their customer ID
        [HttpPut("{id}")]
        public IActionResult Update(int Id, Orders order)
        {
            try
            {
                var context = new DB_DataContext();
                var std = context.Orders.FirstOrDefault(x => x.CustomerId == Id);
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
        [HttpDelete("{id}")]
        public IActionResult DeleteOrderAndCustomer(int Id) 
        {
            try
            {
                var context = new DB_DataContext();

                var std = context.Orders.FirstOrDefault(x => x.CustomerId == Id); // Query to delete from order table.
                context.Orders.Remove(std);
                var std1 = context.Customer.FirstOrDefault(c => c.CustomerId == Id); // Query to delete from the customer table.
                context.Customer.Remove(std1);
                context.SaveChanges();
                return Ok("Row Deleted from the Orders and the Customer table.");
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}