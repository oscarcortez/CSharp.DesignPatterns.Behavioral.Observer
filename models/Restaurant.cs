using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models
{
    public class Restaurant : IRestaurant
    {
        private string _name;
        private Veggies _veggie;
        private double _purchaseThreshold;

        public Restaurant(string name, double purchaseThreshold)
        {
            _name = name;
            _purchaseThreshold = purchaseThreshold;
        }

        public void Update(Veggies veggie)
        {
            Console.WriteLine($"Notified {_name} of {veggie.GetType().Name}'s price change to {veggie.PricePerPound} per pound");

            if (veggie.PricePerPound < _purchaseThreshold)
                Console.WriteLine($"{_name} wants to buy some {veggie.GetType().Name} !");            
        }
    }
}
