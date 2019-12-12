using System.Collections.Generic;

namespace Service.Service.Data
{
    public interface IDataService
    {
        List<DataDTO> LoadFile(string path);
        void SaveFile(List<DataDTO> podaciDTO);
    }
}
