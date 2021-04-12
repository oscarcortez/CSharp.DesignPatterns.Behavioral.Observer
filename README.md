# CSharp.DesignPatterns.Behavioral.Observer

Un objeto en cuestion sabe que otros objetos lo observan
Cuando hay algun cambio de estado en el objeto, los observadores son notificados automaticamente

la clase a la cual revisan si hay cambio de estado es: 
```csharp
public class Veggies {}
```
Aqui estan los observadores
```csharp
public class Veggies
{...
    private List<IRestaurant> _restaurants = new();
...
}
```
los observadores son notificados mediante este metodo:
```csharp
public void Notify()
{
    _restaurants.ForEach(restaurant =>
    {
        restaurant.Update(this);
    });
    Console.WriteLine();
}
```

el estado a ser revisado es PricePerBound, y se notifica cuando cambia su estado
```csharp
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
```

La clase observadora es Restaurant:
Como vemos se pasa el objeto completo a ser observado (Veggies)
```csharp
public void Update(Veggies veggie)
{
    Console.WriteLine($"Notified {_name} of {veggie.GetType().Name}'s price change to {veggie.PricePerPound} per pound");

    if (veggie.PricePerPound < _purchaseThreshold)
        Console.WriteLine($"{_name} wants to buy some {veggie.GetType().Name} !");            
}
```

Se suscribe a los observadores: 
```csharp
Carrots carrots = new(0.82);
carrots.Attach(new Restaurant("Rest 1", 0.77));
carrots.Attach(new Restaurant("Rest 2", 0.74));
carrots.Attach(new Restaurant("Rest 3", 0.75));
```

y las notificaciones se ejecutan en cuanto cambia el estado
```csharp
carrots.PricePerPound = 0.79;
carrots.PricePerPound = 0.76;
carrots.PricePerPound = 0.74;
carrots.PricePerPound = 0.81;
```

