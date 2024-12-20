using System.ComponentModel.DataAnnotations;

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

        [MaxLength(255)]
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        [MaxLength(500)]
        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public Item(string name, string description)
        {
            Name = name;
            Description = description;
        }


    }

    public class ItemFactory
    {
        public static Item Create(string name, string description)
        {

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is not valid");
            }

            return new Item(
                name, 
                string.IsNullOrWhiteSpace(description) ? string.Empty : description
                );
        }
    }
}
