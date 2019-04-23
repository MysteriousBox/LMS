using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMS.Core.Entities.CollectionInfo
{
    public class ShelfItem:BaseEntity
    {
        public int Quanity { get; set; }
        public string ResourceId { get; set; }
        public string Tier { get; set; }
        public string ShelfFace { get; set; }
    }
}
