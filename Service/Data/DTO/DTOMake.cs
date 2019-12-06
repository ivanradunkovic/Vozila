using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Data
{
    abstract class DTOMake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
