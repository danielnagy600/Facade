//The intent of this pattern is ToString provide a unified interface to a set of interfaces in a subsystem. Ut defines a higher-level interface that
//makes the subsystem easier to use.
//hide complexities

//Use Cases
//simple interface complex subsystem
//Content management system

using Facade;

var facade = new DiscountFacade();
Console.WriteLine($"Discount percentage for customer with id 1: " + $"{facade.CalculateDiscountPercentage(1)}");
Console.WriteLine($"Discount percentage for customer with id 10: " + $"{facade.CalculateDiscountPercentage(10)}");
Console.ReadKey();
