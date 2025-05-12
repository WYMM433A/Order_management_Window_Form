using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODM.DAL;

namespace ODM.BLL
{
    public class ItemService
    {
        private readonly ItemRepository _itemRepository;

        public ItemService(ItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        public void AddItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            if (string.IsNullOrWhiteSpace(item.ItemName))
                throw new ArgumentException("Item Name is required.");

            _itemRepository.AddItem(item);
        }

        public List<Item> GetItems()
        {
            return _itemRepository.GetItems();
        }

        public Item GetItemById(int itemId)
        {
            return _itemRepository.GetItemById(itemId);
        }

        public void UpdateItem(Item item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));
            if (_itemRepository.GetItemById(item.ItemID) == null)
                throw new ArgumentException("Item does not exist.");

            _itemRepository.UpdateItem(item);
        }

        public void DeleteItem(int itemId)
        {
            if (_itemRepository.GetItemById(itemId) == null)
                throw new ArgumentException("Item does not exist.");

            _itemRepository.DeleteItem(itemId);
        }
    }
}
