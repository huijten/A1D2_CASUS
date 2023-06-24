using A1D2_CASUS.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1D2_CASUS.Model
{
    
    public class Outfit
    {
        OutfitDAO db = new OutfitDAO();
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public int Cost { get; set; }

        public Outfit() { }
        public Outfit(int id, string name, string description, string imageURL, int cost)
        {
            Id = id;
            Name = name;
            Description = description;
            ImageURL = imageURL;
            Cost = cost;
        }

        public List<Outfit> Read()
        {
            return db.Read();
        }
    }
}
