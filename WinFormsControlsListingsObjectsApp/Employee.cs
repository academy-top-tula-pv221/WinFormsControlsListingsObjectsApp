using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsControlsListingsObjectsApp
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsMarried { get; set; }

        public override string ToString()
        {
            return $"{Name} ({Age}) {(IsMarried ? "Married" : "Single")}";
        }
    }
}
