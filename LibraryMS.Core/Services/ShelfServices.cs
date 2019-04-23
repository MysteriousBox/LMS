using LibraryMS.Core.Entities.CollectionInfo;
using LibraryMS.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMS.Core.Services
{
    public class ShelfServices:IShelfService
    {
        private readonly IAsyncRepository<Shelf> _shelfAsyncRepository;
        private readonly IAsyncRepository<ShelfItem> _shelfItemAsyncRepository;
        //private readonly IAsyncRepository<Tier> _tierAsyncRepository;
        public ShelfServices(IAsyncRepository<Shelf> shelfAsyncRepository,
            IAsyncRepository<ShelfItem> shelfItemAsyncRepository
            /*IAsyncRepository<Tier> tierAsyncRepository*/)
        {
            _shelfAsyncRepository = shelfAsyncRepository; 
            _shelfItemAsyncRepository = shelfItemAsyncRepository;
            //_tierAsyncRepository = tierAsyncRepository;
        }

        public async Task AddItemToShelf(string shelfID, string resourceId,string shelfFace,string tier, int quantity)
        {
            var shelf = await _shelfAsyncRepository.GetByIDAsync(shelfID);
            shelf.AddBookItem(resourceId, shelfFace, tier, quantity);
            await _shelfAsyncRepository.UpdateAsync(shelf);
        }
        
        public async Task CreateShelfAsync(string shelfName, string locationID, int tierNumber, int tierCapacity)
        {
            var tempShelf = new Shelf(shelfName,tierNumber,locationID);
            GenerateTire(tempShelf,tierCapacity);
            await _shelfAsyncRepository.AddAsync(tempShelf);
        }
        private void GenerateTire(Shelf shelf,int tierCapacity)
        {
            for(int i=0;i<shelf.LayerNumber;i++)
            {
                var name = (i+1) + " tier";
                shelf.AddTier(name, tierCapacity);
            }
        }
        public Task<int> GetShelfTierCountAsync()
        {
            throw new NotImplementedException();
        }
    }
}
