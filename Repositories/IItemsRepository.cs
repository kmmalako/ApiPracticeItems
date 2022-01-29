using Catalog.Entities;
using System;
using System.Collections.Generic;

namespace Catalog.Repositories
{
    public interface IItemsRepository
    {
        Item GetItem(Guid id);  //GET (all)
        IEnumerable<Item> GetItems();  //GET (specified item)

        void CreateItem(Item item);  // POST

        void UpdateItem(Item item);  //PUT

        void DeleteItem(Guid id);  // DELETE
    }
}