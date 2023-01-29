namespace WebApplicationtask2.Models
{
    public class Model
    {
        public int Id { get; set; }      
        public string Name { get; set; }
        //public int CarCount { get; set; }     
        public int MarkaId { get; set; }  
        //public List<Car> Cars { get; set; }
        public Marka Marka { get; set; }
        public List<Car> Cars { get; set; }

    }
}
