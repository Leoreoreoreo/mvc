namespace MVC
{
    public class Authors
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public List<Books> Books {get; set; } =[];
    }
}
