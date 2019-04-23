using LibraryMS.Core.Entities.CollectionInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMS.Core.Entities.Books
{
    public class Book : BaseEntity
    {
        public string ISBN { get; set; }
        public string EnglishTitle { get; set; }
        public string Edition { get; set; }
        public string Binding { get; set; }
        public string ContentOverview { get; set; }
        public string PublishingHouse { get; set; }
        public string PublishingDate { get; set; }
        public decimal Pricing { get; set; }
        public List<Author> Authors { get; set; }
    }
}
