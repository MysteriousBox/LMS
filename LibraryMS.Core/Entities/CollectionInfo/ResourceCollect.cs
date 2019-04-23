using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LibraryMS.Core.Entities.CollectionInfo
{
    class ResourceCollect
    {
        public string AdminiId { get; set; }

        private readonly List<ResourceCollectItem> _items = new List<ResourceCollectItem>();
        public IReadOnlyCollection<ResourceCollectItem> Items => _items.AsReadOnly();
        public void AddItem(string resourceName,string resourceID,string shelfID,int quantity)
        {
            _items.Add(new ResourceCollectItem()
            {
                ResourceName = resourceName,
                ResourceID = resourceID,
                ShelfID = shelfID,
                Quantity = quantity
            });
        }
    }
}
