using LibraryMS.Core.Entities.CollectionInfo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Interfaces
{
    public interface IShelfService
    {
        Task<int> GetShelfTierCountAsync();
        Task CreateShelfAsync(string ShelfName,string location,int tierNumber,int tierCapacity);
        Task AddItemToShelf(string shelfID, string resourceId, string shelfFace, string tier, int quantity);
    }
}
