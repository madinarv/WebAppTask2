namespace WebApplicationtask2.Models
{
    public class Marka
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        //public int ModelId { get; set; }
        public List<Model> Models { get; set; }
    }
}
