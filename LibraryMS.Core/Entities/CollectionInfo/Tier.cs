using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMS.Core.Entities.CollectionInfo
{
    public class Tier:BaseEntity
    {
        public string Name { get; set; }
        public string ShelfSurface { get; set; }
        public int Capacity { get; set; }
        public int SpaceAvailable { get; set; }
    }
}
