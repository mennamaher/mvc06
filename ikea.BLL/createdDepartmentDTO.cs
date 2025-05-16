using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.BLL
{
    public class createdDepartmentDTO
    {
        public string Name { get; set; } = null!;

        public string? Description { get; set; } = null!;

        public string code { get; set; } = null!;
        public DateOnly CreationDate { get; set; }
    }
}
