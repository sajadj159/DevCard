namespace DevCard_MVC.Models
{
    public class Project
    {
        public long Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string Client { get; private set; }
        public string Image { get; private set; }

        public Project(long id, string name, string description, string client, string image)
        {
            Id = id;
            Name = name;
            Description = description;
            Client = client;
            Image = image;
        }
    }
}