using System.Collections.Generic;
using ServiceVozila.Service.Data.DTO;

namespace ServiceVozila.Service.Data
{
    public interface IDataServiceMake
    {
        List<ModelDTO> LoadFile(string path);
        void SaveFile(List<ModelDTO> podaciDTO);
    }
}