using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.DAL.modelss
{
    public class ModelBase
    {
        public int id {  get; set; }
        public int createdBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int LastModification { get; set; }
        public DateTime LastModifiedOn { get; set; }
        public bool IsDeleted { get; set; }



    }
}
