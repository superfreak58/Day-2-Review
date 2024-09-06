namespace Day_2_Review
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string favMovie;
            string quote;
            firstName = "RayJ";
            favMovie = "The Matrix";
            quote = "Im Lovin It";
            Console.WriteLine($"Hello Everyone, my name is {firstName.ToLower()} and my favorite movie is {favMovie.ToUpper()}");
            Console.WriteLine(favMovie.Contains("The"));
           Console.WriteLine();
            favMovie = favMovie.Replace("a", "@"); favMovie = favMovie.Replace("e", "3");
            Console.WriteLine(favMovie);
            quote = quote.Replace("o", ""); quote = quote.Replace("I", "");
            Console.WriteLine(quote);
            




            Console.WriteLine(" /                \\                            / /           \\ \\ \r\n     / /          \\ \\   \\                          |    -    -       \\\r\n     |                  |                          | /        -   \\  |\r\n    /                  /                           \\                 \\\r\n   |      ___\\ \\| | / /                             \\____________  \\  \\\r\n   |      /           |                             |            \\    | \r\n   |      |     __    |                             |             \\   \\ \r\n  /       |       \\   |                             |              \\  | \r\n  |       |        \\  |                             | ====          | |\r\n  |       |       __  |                             | (o-)      _   | | \r\n  |      __\\     (_o) |                             /            \\  | |\r\n  |     |             |     Heh Heh Heh            /            ) ) | |\r\n   \\    ||             \\      /      Huh Huh Huh  /             ) / | | \r\n    |   |__             \\    /                \\  |___            - |  | \r\n    |   |           (*___\\  /                  \\    *'             |  |\r\n    |   |       _     |    /                    \\  |____           |  |\r\n    |   |    //_______|                             ####\\          |  |\r\n    |  /       |_|_|_|___/\\                        ------          |_/  \r\n     \\|       \\ -         |                        |                | \r\n      |       _----_______/                        \\_____           | \r\n      |      /                                          \\           |\r\n      |_____/                                            \\__________|");
            Console.WriteLine("    ,-'\"\"\"\"`-._\r\n              ,' // <->    \"-.\r\n              | '` ,;;;....__|\r\n              |   /._''''''''                       ,\r\n               | `--._\"-._                         /|\r\n                | ===|\"-__'                    _.-'/\r\n              .-: ==||-\"'\"-'--.          _..--' ,-'\r\n  ,,--\"\"\"--._ ( |\\__||         |____----\"   _.-\"\r\n  VV--\"\\ ,_  \"',\\  .-,`---.-,  `-_   __..--\"\r\n,'_/_-\"`V' \"-./_ `\\.` `     |    _'\"\"\r\n|__|__.-|     | \"-. `------' `,-\"\r\n`.-\\-_ ,'      |  |\"\"\"---._,-\"'`]\"\"-.\r\n  `-`-'        ;--;,        `._ /  ||\r\n            ,\"\"`   |           ,\"  ||\r\n            VV_.==='           VV--'");
        }
    }
}
