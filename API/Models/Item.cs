namespace API.Models
{
    public class Item
    {

        private int _id = 0;
        private string _name = string.Empty;
        private string _description = string.Empty;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public Item(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }


    }

    public class ItemFactory
    {
        public static Item Create(int id, string name, string description)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id is not valid.");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is not valid");
            }

            return new Item(
                id,
                name, 
                string.IsNullOrWhiteSpace(description) ? string.Empty : description
                );
        }
    }
}
