using CsvHelper;
using Service.Infrastructure.Domain;
using Service.Model.Data;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Service.Service.Data
{
    public class DataService : IDataService
    {
        private readonly IDataRepository _makeModelRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DataService(IDataRepository makeModelRepository, IUnitOfWork unitOfWork)
        {
            _makeModelRepository = makeModelRepository;
            _unitOfWork = unitOfWork;
        }

        public static List<DTO.DataDTO> LoadFile(string path)
        {
            StreamReader reader = new StreamReader(path, Encoding.Default);
            var config = new CsvHelper.Configuration.Configuration
            {
                HasHeaderRecord = false,
                Delimiter = ";"
            };

            using (CsvReader csvReader = new CsvReader(reader, config, true))
            {
                return csvReader.GetRecords<DTO.DataDTO>().ToList();
            }
        }

        public void SaveFile(List<DTO.DataDTO> dataDTO)
        {
            foreach (var row in dataDTO)
            {
                var isValid = int.TryParse(row.Name, out int result);
                if (isValid)
                {
                    _makeModelRepository.InsertWithProcedure(new Model.Data.Data
                    {
                        Id = row.Id,
                        Name = row.Name,
                        Abrv = row.Abrv,
                    });
                }
            }
        }

        public void SaveFile(List<DataDTO> dataDTO)
        {
            throw new System.NotImplementedException();
        }

        List<DataDTO> IDataService.LoadFile(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}