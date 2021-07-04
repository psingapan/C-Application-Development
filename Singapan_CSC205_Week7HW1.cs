/*
 * CSC205 Week7 Programming Assignment #1
 * key concepts: abstract class/method; inheritance; constructor; array of objects
 * Shape class: Shape.cs
 */

using System;

public abstract class Shape
{
    public abstract double Area(); //this is a method is declared abstract because it is a method that is shared across all the child classes that contains specific functions.
    public static double GetArea(Shape shape)
    {
        return shape.Area();
    }
}

public class Square : Shape //inheritance
{
    private double size;
    public Square(double length)
    {
        this.size = length;
    }
    public override double Area()
    {
        return Math.Pow(size, 2);
    }
}

public class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.Round(Math.PI * Math.Pow(radius, 2), 2); //This is the Area() method within the Circle class invoked through iteration to return the circle area given a radius of 10.
    }
}

//Add a rectangle class that inherits shape, and test it in program.cs
public class Rectangle: Shape
{
    private double size;

    public Rectangle(double length)
    {
        this.size = length;
    }
    public override double Area()
    {
        return Math.Pow(size, 2);
    }
}

//Extra credit: add a Triangle class and test it in Program.cs.
public class Triangle : Shape
{
    private double b;
    private double h;
    public Triangle (double b , double h)
    {
        this.b = b;
        this.h = h;
    }
    public override double Area()
    {
        return 0.5 * (b * h);
    }
}


/*
 * CSC205 Week7 Programming Assignment #1
 * key concepts: abstract class/method; inheritance; constructor; array of objects
 * Tester: Program.cs
 */

public class Program
{
    public static void Main()
    {
        Shape[] shapes = { new Square(10), new Circle(10), new Rectangle(10), new Triangle(10,10) }; // creating a new shape array to hold the radius and length of the circle and square objects.
                                                            
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Area of {shape}: {shape.Area()}");
            Console.WriteLine($"Area of {shape}: {Shape.GetArea(shape)}, again");
        }
    }
}

// 2) Summarize the whole program and explain the following lines (github file lines): 11, 40 and 55.

//The program displays the area of the shapes stored in the array after being passed the values. The console displays the area twice ( to exemplify the result called from two different methods) for each shape. 
//The results are stored in the (shapes) array.
