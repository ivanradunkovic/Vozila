namespace Vozila.Models
{
    public class MakeModel
    {
        public int MakeModelId { get; set; }
        public int MakeId { get; set; }
        public int ModelId { get; set; }
        public virtual Make Make { get; set; }
        public virtual Model Model { get; set; }
    }
}