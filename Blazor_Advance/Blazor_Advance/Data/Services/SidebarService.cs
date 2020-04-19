using Blazor_Advance.Data.Interface;
using Blazor_Advance.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor_Advance.Data.Services
{
    public class SidebarService : ISidebar
    {
        public List<Sidebar> GetLinks()
        {
            try
            {
                using (var context = new StudentContext())
                {
                    var list = context.Sidebar.ToList();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Sidebar GetLinksById(int id)
        {
            try
            {
                using (var context = new StudentContext())
                {

                    Sidebar sidebar = context.Sidebar.FirstOrDefault(e => e.Id == id);
                    return sidebar;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(Sidebar sidebar)
        {
            try
            {
                using (var context = new StudentContext())
                {

                    context.Sidebar.Add(sidebar);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(Sidebar sidebar)
        {
            try
            {

                using (var context = new StudentContext())
                {
                    context.Sidebar.Update(sidebar);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Delete(Sidebar sidebar)
        {
            try
            {

                using (var context = new StudentContext())
                {
                    context.Sidebar.Remove(sidebar);
                    context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
