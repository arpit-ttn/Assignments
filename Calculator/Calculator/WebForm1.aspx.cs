using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var num1 = Convert.ToDecimal(this.txtNumber1.Text);
            var num2 = Convert.ToDecimal(this.txtNumber2.Text); 
            var optr = this.DropDownList1.SelectedValue;
            var result = 0m;
            //try

            //{
                if (optr == "+")
                {
                    result = num1 + num2;
                }
                else if (optr == "-")
                {
                    result = num1 - num2;
                }
                else if (optr == "*")
                {
                    result = num1 * num2;
                }
                else
                {
                    //try
                    //{


                    //}

                    //// Catch block for inner try block 
                    //catch (DivideByZeroException)
                    //{

                    //    Console.WriteLine("Inner Try Catch Block");
                    //}
                    //// Catch block for outer try block 
                    //catch (IndexOutOfRangeException)
                    //{

                    //    Console.WriteLine("Outer Try Catch Block");
                    //}
                    result = num1 / num2;
                }



            
           
            lblResult.Text = result.ToString();

        }
    }
}