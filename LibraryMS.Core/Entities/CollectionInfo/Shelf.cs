using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace LibraryMS.Core.Entities.CollectionInfo
{
    public class Shelf:BaseEntity
    {
        public string Name { get; private set; }
        //public int LayerCapacity { get; private set; }
        public string LocationID { get; private set; }
        public int LayerNumber { get; set; }

        public Shelf(string name,int layerNumber,string locationsID)
        {
            Name = name;
            LayerNumber = layerNumber;
            LocationID = locationsID;
        }

        private readonly List<ShelfItem> _shelfItems = new List<ShelfItem>();
        public ReadOnlyCollection<ShelfItem> ShelfItems => _shelfItems.AsReadOnly();
        public void AddBookItem(string resourceId,string shelfFace, string tier, int quanity)
        {
            if (!ShelfItems.Any(i => i.ResourceId == resourceId))
            {
                ShelfItem shelfItem = new ShelfItem()
                {
                    ResourceId = resourceId,
                    Quanity = quanity,
                    Tier = tier
                };
                _shelfItems.Add(shelfItem);
                return;
            }
            var existItem = ShelfItems.FirstOrDefault(ID => ID.ResourceId == resourceId);
            existItem.Quanity += quanity;
        }

        private readonly List<Tier> _tiers;
        public IReadOnlyCollection<Tier> Tiers => _tiers.AsReadOnly();

        public void AddTier(string tierName, int capacity)
        {
            _tiers.Add(new Tier() { Name = tierName, Capacity = capacity });   
        }

        public int GetCapacity()
        {
            return  LayerNumber * _tiers.Capacity;
        }
    }
}
