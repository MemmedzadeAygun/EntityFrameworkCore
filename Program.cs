

// See https://aka.ms/new-console-template for more information
using EfCoreTasks1.Classes;
using EfCoreTasks1.Context;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System;

Console.WriteLine("Hello, World!");

using (StoredContext context = new())
{
    //await AddData(context);
    //await UpdateData(context);
    await DeleteData(context);
}



//async Task AddData(StoredContext context)
//{
//    Movies movie = new()
//    {
//        MovieName = "Arsin mal alan",
//        MovieReleaseDate = DateTime.Now,
//        Description = "Qedim Azerbaycan filmi",
//        DirectorId = 2,
//        MoviesImdbDetails = new()
//        {
//            ImdbPoint = 2
//        }
//    };

//    context.Attach(movie).State = EntityState.Added;
//    await context.SaveChangesAsync();
//    Console.WriteLine("Film elave edildi");
//}

//async Task UpdateData(StoredContext context)
//{
//    Movies movie1 = new Movies();

//    var movie2 = await context.Movies.FindAsync(3);
//    movie1.MovieName = "Ulduz";
//    await context.SaveChangesAsync();
//    Console.WriteLine("Film adi deyisdirildi");
//}


async Task DeleteData(StoredContext context)
{
    var movie3 = await context.Movies.FindAsync(6);
    context.Movies.Remove(movie3);

    await context.SaveChangesAsync();
    Console.WriteLine("Film silindi");
}

//using (StoredContext context = new())
//{
//    Movies movie = new()
//    {
//        MovieName = "Kozetta",
//        MovieReleaseDate = DateTime.Now,
//        Description = "About a little girl",
//        DirectorId = 2,
//        MoviesImdbDetails = new()
//        {
//            ImdbPoint = 3
//        }
//    };

//    context.Attach(movie).State = EntityState.Added;
//    await context.SaveChangesAsync();
//    Console.WriteLine();


//    var movie2 = await context.Movies.FindAsync(2);
//    movie.MovieName = "Harry Poter";

//    await context.SaveChangesAsync();

//    var movie3 = await context.Movies.FindAsync(4);

//    context.Movies.Remove(movie3);
//    await context.SaveChangesAsync();
//    Console.WriteLine();

//}
   

   