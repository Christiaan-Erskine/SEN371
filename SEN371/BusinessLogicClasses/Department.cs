using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.BusinessLogicClasses
{
    public abstract class Department
    {
        DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();

        string depName; //identifies the department by name
        string depId;

        public Department(string departmentName)
        {
            this.depName = departmentName;
        }

        public string DepartmentName { get => depName; set => depName = value; }


        public void StoreDepartment(string depName)
        {
            database.Insert("Department", new[] { ("DepartmentName", depName) });
        }

        public void UpdateDepartment(string depName,string depId)
        {       
            database.Update("Department", new[] { ("DepartmentName", depName) }, "DepartmentId = " + depId);
        }

        public void DeleteDepartment(string id)
        {
            database.Delete("Department", "DepartmentId = " + depId);
        }
    }
}
