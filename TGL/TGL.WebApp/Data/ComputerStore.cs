using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL.WebApp.Models;

namespace TGL.WebApp.Data
{
    public class ComputerStore
    {
        public TGLContext Context { get; set; }
        public ComputerStore(TGLContext context)
        {

            Context = context;

        }

        

        internal void DeleteComputers(Guid id)
        {
            var student = Context.Student.FirstOrDefault(x => x.Id == id);
            Context.Student.Remove(student);
            Context.SaveChanges();
        }

        internal List<Computer> GetComputers()
        {
            return Context.Computer.ToList();
        }

        internal Computer GetComputerById(Guid id)
        {
            return Context.Computer.FirstOrDefault(x => x.Id == id);
        }

        internal void AddComputer(Computer computer)
        {
            Context.Computer.Add(computer);
            Context.SaveChanges();
        }

        internal void EditComputer(Computer computer)
        {
            Computer currentComputer = GetComputerById(computer.Id);
            currentComputer.Brand = computer.Brand;
            currentComputer.Model = computer.Model;
            currentComputer.Cpu = computer.Cpu;
            currentComputer.Ram = computer.Cpu;
            Context.Computer.Update(currentComputer);
            Context.SaveChanges();

               
        }
    }
}
