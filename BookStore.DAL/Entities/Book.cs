using System;
using System.Collections.Generic;

namespace BookStore.DAL.Entities;

public partial class Book
{
    public string Upc { get; set; } = null!;

    public string? Name { get; set; }

    public string? Author { get; set; }

    public decimal? Price { get; set; }

    public string? Img { get; set; }
}
