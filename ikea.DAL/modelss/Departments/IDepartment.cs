
namespace ikea.DAL.modelss.Departments
{
    public interface IDepartment
    {
        string code { get; set; }
        DateOnly CreationDate { get; set; }
        string? Description { get; set; }
        string Name { get; set; }
    }
}