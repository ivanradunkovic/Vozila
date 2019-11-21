using System;
using System.Collections.Generic;

namespace Vozila.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual ICollection<Model> Models { get; set; }
    }
}