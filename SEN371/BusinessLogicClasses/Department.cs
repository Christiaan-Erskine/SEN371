using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


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

        public Department()
        {
            
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


        public SqlDataAdapter GetInfo()
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData(this.GetType().Name);
        }


        public SqlDataAdapter GetInfo(string departmentId)
        {
            DataAccessLayer.DataHandler database = new DataAccessLayer.DataHandler();
            return database.RetrieveData(this.GetType().Name, ("departmentId = " + departmentId));
        }

    }
}
