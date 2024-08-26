using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PRG2782 Project
//Jo-Anne van der Wath - 577394
//Henry Roux - 577440
//Caitlin Gerber - 577745
//Leonard Vermeer - 577309

namespace PRG282_Project {
    internal class Module 
    {
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public string Description { get; set; }
        public string Links { get; set; }

        public Module(string moduleCode, string moduleName, string description, string links)
        {
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            Description = description;
            Links = links;
        }
    }
}
