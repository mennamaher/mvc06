using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.DAL.Models.Departments
{
    public class Department : ModelBase
    {
        internal object id;

        public string Name { get; set; } = null!;

        public string? Description { get; set; } = null!;

        public string code { get; set; } = null!;
        public DateOnly CreationDate { get; set; }
        public object CreatedOn { get; internal set; }
        public object LastModification { get; internal set; }
    }

}
