using DSS.VanityFair;

System.Console.WriteLine("Actors");
System.Console.WriteLine();

Actor actor = new Actor(){firstName = "John", lastName = "Goodman", imdbMark = 9.7};
System.Console.WriteLine($"Actor: {actor.firstName} {actor.lastName}, imdb:{actor.imdbMark}");
System.Console.WriteLine();

Actor actor2 = new Actor(){lastName = "De Niro", imdbMark = 9.4, firstName = "Robert"};
System.Console.WriteLine($"Actor: {actor2.firstName} {actor2.lastName}, imdb:{actor2.imdbMark}");
System.Console.WriteLine();

Director director = new Director(){lastName = "Eastwood", numberOfMovies=4, firstName = "Clint"};
System.Console.WriteLine($"Director: {director.firstName} {director.lastName}, #:{director.numberOfMovies}");
System.Console.WriteLine();

