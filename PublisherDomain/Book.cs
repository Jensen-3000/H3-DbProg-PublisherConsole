﻿namespace PublisherDomain;

public class Book
{
    public int BookId { get; set; }
    public string Title { get; set; }
    public DateOnly PublishDate { get; set; }
    public decimal BasePrice { get; set; }
    public Author Author { get; set; }
    public int AuthorId { get; set; }
    public Cover Cover { get; set; }
    public int? CoverId { get; set; }
}
