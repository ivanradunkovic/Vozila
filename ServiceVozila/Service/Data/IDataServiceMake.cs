using System.Collections.Generic;
using ServiceVozila.Service.Data.DTO;

namespace ServiceVozila.Service.Data
{
    public interface IDataServiceMake
    {
        List<MakeDTO> LoadFile(string path);
        void SaveFile(List<MakeDTO> podaciDTO);
    }
}