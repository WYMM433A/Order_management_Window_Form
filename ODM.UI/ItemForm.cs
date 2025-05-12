using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODM.BLL;
using ODM.DAL;

namespace ODM.UI
{
    public partial class ItemForm : Form

    {

        private readonly ItemService _itemService;
        private Item _selectedItem;

        public ItemForm()
        {
            var dbContext = new AppDbContext();
            var itemRepository = new ItemRepository(dbContext);
            _itemService = new ItemService(itemRepository);
            InitializeComponent();
            LoadItems();
        }

        private void ItemForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadItems()
        {
            var items = _itemService.GetItems();
            dgvItems.DataSource = items;

            // Set column headers
            if (dgvItems.Columns["ItemID"] != null)
                dgvItems.Columns["ItemID"].HeaderText = "Item ID";
            if (dgvItems.Columns["ItemName"] != null)
                dgvItems.Columns["ItemName"].HeaderText = "Item Name";
            if (dgvItems.Columns["Size"] != null)
                dgvItems.Columns["Size"].HeaderText = "Size";
        }

        private void ClearForm()
        {
            txtItemID.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtSize.Text = string.Empty;
            dgvItems.ClearSelection();
        }



        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("SelectionChanged event fired.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (dgvItems.SelectedRows.Count > 0)
            {
                var selectedRow = dgvItems.SelectedRows[0];
                _selectedItem = (Item)selectedRow.DataBoundItem;
                txtItemName.Text = _selectedItem.ItemName;
                txtSize.Text = _selectedItem.Size;
                MessageBox.Show($"Selected item: {_selectedItem.ItemName}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _selectedItem = null;
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

            try
            {
                var item = new Item
                {
                    ItemName = txtItemName.Text.Trim(),
                    Size = txtSize.Text.Trim()
                };

                _itemService.AddItem(item);
                LoadItems();
                ClearForm();
                MessageBox.Show("Item added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtItemID.Text.Trim(), out int itemId))
            {
                MessageBox.Show("Please enter a valid Item ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var item = new Item
                {
                    ItemID = itemId,
                    ItemName = txtItemName.Text.Trim(),
                    Size = txtSize.Text.Trim()
                };

                _itemService.UpdateItem(item);
                LoadItems();
                ClearForm();
                MessageBox.Show("Item updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (!int.TryParse(txtItemID.Text.Trim(), out int itemId))
            {
                MessageBox.Show("Please enter a valid Item ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete the item with ID {itemId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                _itemService.DeleteItem(itemId);
                LoadItems();
                ClearForm();
                MessageBox.Show("Item deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void getItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtItemID.Text.Trim(), out int itemId))
            {
                MessageBox.Show("Please enter a valid Item ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var item = _itemService.GetItemById(itemId);
                if (item == null)
                {
                    MessageBox.Show("Item not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearForm();
                    return;
                }

                txtItemName.Text = item.ItemName;
                txtSize.Text = item.Size;
                MessageBox.Show($"Item retrieved: {item.ItemName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
