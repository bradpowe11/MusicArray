namespace MusicArray
{
    class Program
    {
        enum Genre
        {
            Blues,
            Rock,
            Pop,
            EDM,
            Country
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLenght(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                Genre = genre;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist +
                    "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("How many Songs would you like to enter?");
            int size = int.Parse(Console.ReadLine());
            Music[] collection = new Music[size];
            try
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine("Please enter the song title?");
                    collection[i].setTitle(Console.ReadLine());
                    Console.WriteLine("Who is the artist?");
                    collection[i].setArtist(Console.ReadLine());
                    Console.WriteLine("What is the album?");
                    collection[i].setAlbum(Console.ReadLine());
                    Console.WriteLine("What is the song length?");
                    collection[i].setLenght(Console.ReadLine());
                    Console.WriteLine("What is the genre?");
                    Console.WriteLine("B - Blues\nR - Rock\nP - Pop\nE - EDM \nC - Country");
                    Genre tempGenre = Genre.Blues;
                    char g = char.Parse(Console.ReadLine());
                    switch (g)
                    {
                        case 'B':
                            tempGenre = Genre.Blues;
                            break;
                        case 'R':
                            tempGenre = Genre.Rock;
                            break;
                        case 'P':
                            tempGenre = Genre.Pop;
                            break;
                        case 'E':
                            tempGenre = Genre.EDM;
                            break;
                        case 'C':
                            tempGenre = Genre.Country;
                            break;
                    }
                    collection[i].setGenre(tempGenre);
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                for (int i = 0; i < size; i++)
                {
                    Console.WriteLine($"{collection[i].Display()}");
                }
            }

        }
    }
}
