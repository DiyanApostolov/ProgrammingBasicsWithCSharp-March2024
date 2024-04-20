
int countOfMovies = int.Parse(Console.ReadLine());

string maxMovieName = "";
double maxMovieRating = 0;
string minMovieName = "";
double minMovieRating = double.MaxValue;
double allRatings = 0;

for (int i = 0; i < countOfMovies; i++)
{
    string nameOfMovie = Console.ReadLine();
    double ratingOfMovie = double.Parse(Console.ReadLine());

    if (ratingOfMovie > maxMovieRating)
    {
        maxMovieName = nameOfMovie;
        maxMovieRating = ratingOfMovie;
    }

    if (ratingOfMovie < minMovieRating)
    {
        minMovieName = nameOfMovie;
        minMovieRating = ratingOfMovie;
    }

    allRatings += ratingOfMovie;
}

double averageRating = allRatings / countOfMovies;

Console.WriteLine($"{maxMovieName} is with highest rating: {maxMovieRating:F1}");
Console.WriteLine($"{minMovieName} is with lowest rating: {minMovieRating:F1}");
Console.WriteLine($"Average rating: {averageRating:F1}");
