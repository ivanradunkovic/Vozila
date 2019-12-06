using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Data.DTO
{
    abstract class DTOModel
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
