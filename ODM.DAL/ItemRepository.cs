using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODM.DAL
{
    public class ItemRepository
    {
        private readonly AppDbContext _context;

        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }

        public List<Item> GetItems()
        {
            return _context.Items.ToList();
        }

        public Item GetItemById(int itemId)
        {
            return _context.Items.FirstOrDefault(i => i.ItemID == itemId);
        }

        public void UpdateItem(Item item)
        {
            var existingItem = _context.Items.FirstOrDefault(i => i.ItemID == item.ItemID);
            if (existingItem != null)
            {
                existingItem.ItemName = item.ItemName;
                existingItem.Size = item.Size;
                _context.SaveChanges();
            }
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.ItemID == itemId);
            if (item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}
