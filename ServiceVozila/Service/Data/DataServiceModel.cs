using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;
using ServiceVozila.Infrastructure;
using ServiceVozila.Model;

namespace ServiceVozila.Service.Data
{
    abstract class DataServiceMake : IDataServiceMake
    {
        private readonly IDataRepository _podaciRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DataServiceMake(IDataRepository podaciRepository, IUnitOfWork unitOfWork)
        {
            _podaciRepository = podaciRepository;
            _unitOfWork = unitOfWork;
        }

        public List<DTO.ModelDTO> LoadFile(string path)
        {
            StreamReader reader = new StreamReader(path, Encoding.Default);
            var config = new CsvHelper.Configuration.Configuration
            {
                HasHeaderRecord = false,
                Delimiter = ";"
            };

            using (CsvReader csvReader = new CsvReader(reader, config, true))
            {
                return csvReader.GetRecords<DTO.ModelDTO>().ToList();
            }
        }

        public void SaveFile(List<DTO.ModelDTO> podaciDTO)
        {
            foreach (var row in podaciDTO)
            {
                var isValid = int.TryParse(row.Name, out int result);
                if (isValid)
                {
                    _podaciRepository.InsertWithProcedure(new Data
                    {
                        Id = row.Id,
                        MakeId = row.MakeId,
                        Name = row.Name,
                        Abrv = row.Abrv
                    });
                }
            }
        }
    }
}