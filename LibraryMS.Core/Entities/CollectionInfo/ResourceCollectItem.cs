using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMS.Core.Entities.CollectionInfo
{
    public class ResourceCollectItem:BaseEntity
    { 
        public string ResourceName { get; set; }
        public string ResourceID { get; set; }
        public string ClassNumber { get; set; }
        public string ShelfID { get; set; }
        public string CallNumber { get; set; }
        
        public int Quantity { get; set; }
    }
}
