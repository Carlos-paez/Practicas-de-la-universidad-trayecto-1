﻿/*using System;
namespace Program
{
	class Hello
	{
		public static void Main(string[] args)
		{
			
			/*   ARRAY EN C#
  			var array = new string [] {"Hola", "Mundo", "Carlos"};
			Console.WriteLine(array[2]);
			
			
			
			
			Console.ReadKey(true);
		}
	}
}*/



using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    // Other properties, methods, events...
}

class Program
{
    static void Main()
    {
        Person person1 = new Person("Leopold", 6);
        Console.WriteLine("person1 Name = {person1.Name} Age = {person1.Age}");

        // Declare new person, assign person1 to it.
        Person person2 = person1;

        // Change the name of person2, and person1 also changes.
        person2.Name = "Molly";
        person2.Age = 16;

        Console.WriteLine("person2 Name = {person2.Name} Age = {person2.Age}");
        Console.WriteLine("person1 Name = {person1.Name} Age = {person1.Age}");
    }
}
/*
    Output:
    person1 Name = Leopold Age = 6
    person2 Name = Molly Age = 16
    person1 Name = Molly Age = 16
*/