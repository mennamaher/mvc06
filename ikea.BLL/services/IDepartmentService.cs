using ikea.BLL.Department;
using ikea.BLL.Models;
using ikea.DAL.Models.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ikea.BLL.Models.Department;

namespace ikea.BLL.services
{
    public interface IDepartmentService
    {
        IEnumerable<DepartmentServices> GetAllDepartments();

        DepartmentToReturnDTO? GetDepartmentById(int id);

        int createDepartmeb(createdDepartmentDTO departmentDTO);
        int updateDepartmeb(updatedDepartmentDTO departmentDTO);
        bool deleteDepartment(int id);
    }
}
