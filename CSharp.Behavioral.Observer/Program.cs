using System;
using models;

namespace CSharp.Behavioral.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrots carrots = new(0.82);
            carrots.Attach(new Restaurant("Rest 1", 0.77));
            carrots.Attach(new Restaurant("Rest 2", 0.74));
            carrots.Attach(new Restaurant("Rest 3", 0.75));

            carrots.PricePerPound = 0.79;
            carrots.PricePerPound = 0.76;
            carrots.PricePerPound = 0.74;
            carrots.PricePerPound = 0.81;

            Console.ReadKey();
        }
    }
}
