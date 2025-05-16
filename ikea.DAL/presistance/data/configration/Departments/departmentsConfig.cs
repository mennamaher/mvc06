using ikea.DAL.Models.Departments;
using ikea.DAL.modelss.Departments;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ikea.DAL.presistance.data.configration.Departments
{
    internal class departmentsConfig:IEntityEntryGraphIterator<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder) {
            builder.Property(D => D.id).UseIdentityColumn(10, 10);
            builder.Property(D => D.Name).HasColumnType("varchar(50)").IsRequired();
            builder.Property(D => D.code).HasColumnType("varchar(50)").IsRequired();
            builder.Property(D => D.CreatedOn).HasDefaultValueSql("GETDATE()");
            builder.Property(D => D.LastModification).HasComputedColumnSql("GETDATE()");
        }
    }
}
