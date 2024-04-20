
string nameOfMovie = Console.ReadLine();
int countOfDays = int.Parse(Console.ReadLine());
int countOfTicketsPerDay = int.Parse(Console.ReadLine());
double priceOfTicket = double.Parse(Console.ReadLine());
int percentProfit = int.Parse(Console.ReadLine());

int allTickets = countOfDays * countOfTicketsPerDay;
double profitFromTickets = allTickets * priceOfTicket;
double cinemaProfit = profitFromTickets * percentProfit / 100;

double finalProfit = profitFromTickets - cinemaProfit;

Console.WriteLine($"The profit from the movie {nameOfMovie} is {finalProfit:F2} lv.");
