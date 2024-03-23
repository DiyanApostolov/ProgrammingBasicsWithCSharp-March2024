double tripPrice = double.Parse(Console.ReadLine());

int puzzlesQuantity = int.Parse(Console.ReadLine());
int dollsQuantity = int.Parse(Console.ReadLine());
int bearsQuantity = int.Parse(Console.ReadLine());
int minionsQuantity = int.Parse(Console.ReadLine());
int trucksQuantity = int.Parse(Console.ReadLine());

double money = puzzlesQuantity * 2.60
                + dollsQuantity * 3
                + bearsQuantity * 4.1
                + minionsQuantity * 8.2
                + trucksQuantity * 2;

int toyQuantity = puzzlesQuantity
                + dollsQuantity
                + bearsQuantity 
                + minionsQuantity
                + trucksQuantity;

if (toyQuantity >= 50)
{
    //money -= money * 0.25;
    money = money - money * 0.25;
}

money = money - money * 0.10;
//money -= money * 0.10;

if (tripPrice <= money)
{
    Console.WriteLine($"Yes! {money-tripPrice:f2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {tripPrice-money:f2} lv needed.");
}