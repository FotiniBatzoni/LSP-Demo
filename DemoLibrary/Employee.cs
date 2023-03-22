using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Employee : BaseEmployee
    {
        public Employee Manager { get; set; } = null;


        public virtual void AssignManager(Employee manager)
        {
            Manager = manager;
        }

    }
}
