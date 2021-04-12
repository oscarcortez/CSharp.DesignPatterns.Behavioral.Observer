using System;
using System.Collections.Generic;

namespace models
{
    public class Veggies
    {
        private double _pricePerPound;
        private List<IRestaurant> _restaurants = new();

        public Veggies(double pricePerPound) => _pricePerPound = pricePerPound;

        public void Attach(IRestaurant restaurant) => _restaurants.Add(restaurant);

        public void Detach(IRestaurant restaurant) => _restaurants.Remove(restaurant);

        public void Notify()
        {
            _restaurants.ForEach(restaurant =>
            {
                restaurant.Update(this);
            });
            Console.WriteLine();
        }

        public double PricePerPound
        {
            get 
            { 
                return _pricePerPound; 
            }
            set
            {
                if(_pricePerPound != value)
                {
                    _pricePerPound = value;
                    Notify();
                }
            }
        }
    }
}
