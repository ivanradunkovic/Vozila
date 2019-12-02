using System.Collections.Generic;

namespace Vozila.Models
{
    public class Make
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public virtual ICollection<MakeModel> MakeModels { get; set; }
    }
}