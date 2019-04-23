using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMS.Core.Entities.CollectionInfo
{
    public class CollectionArea:BaseEntity
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Floor { get; set; }
    }
}
