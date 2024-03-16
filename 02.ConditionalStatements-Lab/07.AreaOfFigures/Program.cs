
//square, rectangle, circle или triangle

string figure = Console.ReadLine();
double area = 0;

if (figure == "square")
{
    double side = double.Parse(Console.ReadLine());
    area = side * side;
} 
else if (figure == "rectangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double sideB = double.Parse(Console.ReadLine());
    area = sideA * sideB;
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());
    area = Math.PI * Math.Pow(radius, 2);
} 
else if (figure == "triangle")
{
    double sideA = double.Parse(Console.ReadLine());
    double hideA = double.Parse(Console.ReadLine());
    area = sideA * hideA / 2;
}

Console.WriteLine($"{area:F3}");



