using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vozila.Models
{
    public class Model
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual ICollection<MakeModel> MakeModels { get; set; }
    }
}