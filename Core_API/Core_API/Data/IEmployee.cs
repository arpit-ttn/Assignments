using Core_API.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Core_API.Data
{
    public interface IEmployee
    {
        DataSet GetData();
        DataSet GetDataId(int id);
        bool InsertData(Employee employee);
        bool UpdateData(int id, Employee employee);
        bool DeleteData(int id);
    }
}
