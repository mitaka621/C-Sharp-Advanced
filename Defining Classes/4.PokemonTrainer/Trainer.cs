using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Trainer
    {
        List<Pokemon> collection;
        public Trainer(string name)
        {
            Name = name;
            NumBadges = 0;
            Collection= new List<Pokemon>();
        }

        public string Name { get; set; }
        public int NumBadges { get; set; }
        public List<Pokemon> Collection { get => collection; set => collection = value; }
    }
}
