namespace ServiceVozila.Service.Data.DTO
{
    abstract class ModelDTO
    {
        public int Id { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
    }
}
