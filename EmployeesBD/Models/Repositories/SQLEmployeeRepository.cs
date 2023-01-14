using EmployeesBD.Data;
using Microsoft.EntityFrameworkCore;

namespace EmployeesBD.Models.Repositories
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        //injecter les dependances des classes appdbcontext dans constructeur
        public SQLEmployeeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Employee Add(Employee employee)
        {
            if (employee != null)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return employee;
            }
            else
            {
                return null;
            }
        }
        public Employee Delete(int Id)
        {
            //find uniquement reserve pour le pk ..methode dbset context 
            Employee employee = context.Employees.Find(Id);
            if (employee != null)
            {
                context.Employees.Remove(employee);
                //Enregistrement dans la BD
                context.SaveChanges();
            }
            return employee;
        }
        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }
        public Employee GetEmployee(int Id)
        {
            return context.Employees.Find(Id);
        }

        public Employee Update(Employee employeeChanges)
        {
           var employee = context.Employees.Attach(employeeChanges);
            //State:Modified,AddChange,Added,Deleted
            employee.State=EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
