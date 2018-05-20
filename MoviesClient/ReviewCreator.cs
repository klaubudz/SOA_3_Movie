using MoviesClient.Services;
using MoviesClient.Services2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesClient
{
    public class ReviewCreator
    {
        private readonly IMovieService _movieService = new MovieServiceClient();
        private readonly IReviewPersonService _reviewPersonService = new ReviewPersonServiceClient();

        private int _myId = 0;

        public void SeedMovies()
        {
            if (!_movieService.GetAll().Any())
            {
                _movieService.Create(new Movie() {
                    Title = "Piraci z Karaibow",
                    ReleaseYear = 2005
                });
                _movieService.Create(new Movie()
                {
                    Title = "Love is in the air",
                    ReleaseYear = 2017
                });
                _movieService.Create(new Movie()
                {
                    Title = "Shrek",
                    ReleaseYear = 2003
                });
            }
        }

        public void InitializeReviewAuthor()
        {
            Console.WriteLine("Podaj swoje imię: ");
            var name = Console.ReadLine();
            Console.WriteLine("Podaj swoje nazwisko: ");
            var surname = Console.ReadLine();
            _myId = _reviewPersonService.CreatePerson(new Person()
            {
                Name = name,
                Surname = surname
            });
        }

        public void ShowMenu()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("a) Dodaj recenzję");
            Console.WriteLine("b) Edytuj recenzję");
            Console.WriteLine("c) Usuń recenzję");
            Console.WriteLine("d) Zobacz recenzje dla filmów");
            Console.WriteLine("e) Dodaj film");
            Console.WriteLine("");
            Console.WriteLine("-----------------");
            Console.WriteLine("");
        }

        public void AddReview()
        {
            ShowMoviesList();
            Console.WriteLine("Wpisz nr filmu, który chcesz ocenić: ");
            var readNum = Console.ReadLine();
            bool isNumber = int.TryParse(readNum, out int num);
            if (isNumber)
            {
                Console.WriteLine("Wpisz swoją recenzję. Naciśniecie Enter kończy wpisywanie.");
                var content = Console.ReadLine();
                Console.WriteLine("Wpisz ocenę filmu w skali 0-100: ");
                var readScore = Console.ReadLine();
                bool isRightscore = int.TryParse(readScore, out int score);
                if(isRightscore && score >= 0 && score <= 100)
                {
                    _reviewPersonService.CreateReview(new Review()
                    {
                        Content = content,
                        Score = score,
                        Author = _reviewPersonService.GetPerson(_myId),
                        Movie = num
                    });
                }
                else
                {
                    Console.WriteLine("Ocena spoza zakresu");
                }
            }
            else
            {
                Console.WriteLine("To nie numer...");
            }
        }

        public void EditReview()
        {
            ShowReviews();
            Console.WriteLine("Wpisz nr recenzji, którą chcesz zmienić: ");
            var readNum = Console.ReadLine();
            bool isNumber = int.TryParse(readNum, out int num);
            if (isNumber)
            {
                var currentReview = _reviewPersonService.GetReview(num);

                Console.WriteLine(currentReview.Content);
                Console.WriteLine();
                Console.WriteLine("Ocena: {0}", currentReview.Score);
                Console.WriteLine();
                Console.WriteLine("Wpisz swoją recenzję. Naciśniecie Enter kończy wpisywanie.");
                var content = Console.ReadLine();
                Console.WriteLine("Wpisz ocenę filmu w skali 0-100:  ");
                var readScore = Console.ReadLine();
                bool isRightscore = int.TryParse(readScore, out int score);
                if (isRightscore && score >= 0 && score <= 100)
                {
                    currentReview.Content = content;
                    currentReview.Score = score;
                    _reviewPersonService.UpdateReview(currentReview);
                }
                else
                {
                    Console.WriteLine("Ocena spoza zakresu");
                }
            }
            else
            {
                Console.WriteLine("Błąd");
            }
        }

        //======
        private void ShowMoviesList()
        {
            var stringBuilder = new StringBuilder();
            var moviesList = _movieService.GetAll();

            foreach (var movie in moviesList)
            {
                stringBuilder
                    .Append("Id: ")
                    .Append(movie.Id)
                    .Append(" Tytuł: ")
                    .Append(movie.Title)
                    .Append(" Rok produkcji: ")
                    .Append(movie.ReleaseYear)
                    .AppendLine();
            }

            Console.WriteLine(stringBuilder.ToString());
        }

        private void ShowReviews()
        {
            var stringBuilder = new StringBuilder();
            var reviewsList = _reviewPersonService.GetAllReviews();

            foreach (var review in reviewsList)
            {
                var movie = _movieService.Get(review.Movie);
                stringBuilder
                    .Append("Id: ")
                    .Append(review.Id)
                    .Append(" Oceniony film: ")
                    .Append(movie.Title)
                    .Append(" Ocena: ")
                    .Append(review.Score)
                    .AppendLine();
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
