using Microsoft.EntityFrameworkCore;
using PublisherData;
using PublisherDomain;


//GetAuthors();
//AddAuthor();
//GetAuthors();

AddAuthorWithBook();


void DeleteAuthorFind()
{
    using var context = new PubContext();
    var author = context.Authors.Find(1);
    if (author is not null)
    {
        context.Authors.Remove(author);
        context.SaveChanges();
    }
}

void DeleteAuthorFirstOrDefault()
{
    using var context = new PubContext();
    var author = context.Authors.FirstOrDefault(a => a.Id == 1);
    if (author is not null)
    {
        context.Authors.Remove(author);
        context.SaveChanges();
    }
}

void AddAuthor()
{
    var author = new Author
    {
        FirstName = "Julie",
        LastName = "Lerman"
    };
    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthors()
{
    using var context = new PubContext();
    var authors = context.Authors.ToList();

    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
    }
}

void AddAuthorWithBook()
{
    var author = new Author { FirstName = "Julie", LastName = "Lerman" };
    author.Books.Add(new Book
    {
        Title = "Programming Entity Framework",
        PublishDate = new DateOnly(2009, 1, 1)
    });

    author.Books.Add(new Book
    {
        Title = "Programming Entity Framework 2nd Ed",
        PublishDate = new DateOnly(2010, 8, 1)
    });
    using var context = new PubContext();
    context.Authors.Add(author);
    context.SaveChanges();
}

void GetAuthorsWithBooks()
{
    using var context = new PubContext();
    var authors = context.Authors.Include(a => a.Books).ToList();
    foreach (var author in authors)
    {
        Console.WriteLine(author.FirstName + " " + author.LastName);
        foreach (var book in author.Books)
        {
            Console.WriteLine(book.Title);
        }

    }
}
