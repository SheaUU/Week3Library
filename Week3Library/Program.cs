using Week3Library;

Book book = new Book();

//this is for the book class
book.Title = "C# for beginners";
book.Author = "Bill gates";
book.ISBN = 1234567;
book.DisplayInfo();

//Add another book
Book book1 = new Book();

book1.Title = "Methods and classes";
book1.Author = "Microsoft";
book1.ISBN = 7654321;
book1.DisplayInfo();
