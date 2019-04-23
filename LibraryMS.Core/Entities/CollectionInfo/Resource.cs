using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMS.Core.Entities.CollectionInfo
{
    public class Resource:BaseEntity
    {
        public string Title { get; set; }
        public string CallNumber { get; set; }
        public string CollectionStatus { get; set; }
        public int BorrowingsNumber { get; set; }
        public int RenewNumber { get; set; }
    }
}
