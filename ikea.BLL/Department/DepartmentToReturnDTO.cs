using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.BLL.Department
{
    public class DepartmentToReturnDTO
    {

        public int id { get; set; }
        //public int createdBy { get; set; }
        //public DateTime CreatedOn { get; set; }
       // public int LastModification { get; set; }
        //public DateTime LastModifiedOn { get; set; }
       // public bool IsDeleted { get; set; }

        public string Name { get; set; } = null!;

        public string? Description { get; set; } = null!;

        public string code { get; set; } = null!;
        public DateOnly CreationDate { get; set; }
    }
}
