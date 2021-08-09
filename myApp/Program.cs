using System;
using mongo_docker_sample.Models;
using mongo_docker_sample.Services;

namespace mongo_docker_sample
{
    class Program
    {

        static string DatabaseName = Environment.GetEnvironmentVariable("DATABASE_NAME");
        static string DatabaseUser = Environment.GetEnvironmentVariable("DATABASE_USERNAME");
        static string DatabasePwd = Environment.GetEnvironmentVariable("DATABASE_PASSWORD");
        static string DatabaseHost = Environment.GetEnvironmentVariable("DATABASE_HOST");

        static void Main(string[] args)
        {
            string action = args.Length > 0
                ? args[0]
                : "";
            string MongoDBConnectionString = $"mongodb://{DatabaseUser}:{DatabasePwd}@{DatabaseHost}:27017/?authSource=admin";

            var Service = new BookService(MongoDBConnectionString, DatabaseName);

            switch (action)
            {
                case "add":
                    string bookName = args.Length > 1
                     ? args[1]
                     : "Livre sans nom";

                     decimal bookPrice = args.Length > 2
                     ? decimal.Parse(args[2])
                     : 1m;
                    Book book = new Book(bookName, bookPrice);
                    Service.Create(book);
                    var booksAdd = Service.Get();
                    booksAdd.ForEach(Console.WriteLine);
                    break;
                default:
                    var books = Service.Get();
                    books.ForEach(Console.WriteLine);
                    break;

            }
        }
    }
}