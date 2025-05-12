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
    public partial class MainForm : Form
    {
        private readonly User _currentUser;
        private readonly OrderService _orderService;
        private readonly AgentService _agentService;
        private readonly ItemService _itemService;

        public MainForm(User currentUser)
        {
            _currentUser = currentUser;

            var dbContext = new AppDbContext();
            var orderRepository = new OrderRepository(dbContext);
            var agentRepository = new AgentRepository(dbContext);
            var itemRepository = new ItemRepository(dbContext);
            _orderService = new OrderService(orderRepository, agentRepository, itemRepository);
            _agentService = new AgentService(agentRepository);
            _itemService = new ItemService(itemRepository);

            InitializeComponent();
            LoadBestSellingItems();
            LoadItemsDropdown();
            LoadAgentsDropdown();
            

        }

        private void LoadBestSellingItems()
        {
            var bestItems = _orderService.GetBestItems();
            dgv_bestItem.DataSource = bestItems.Select(x => new
            {
                ItemName = x.Item.ItemName,
                TotalQuantity = x.TotalQuantity
            }).ToList();

            if (dgv_bestItem.Columns["ItemName"] != null)
                dgv_bestItem.Columns["ItemName"].HeaderText = "Item Name";
            if (dgv_bestItem.Columns["TotalQuantity"] != null)
                dgv_bestItem.Columns["TotalQuantity"].HeaderText = "Total Quantity Sold";
        }

        private void LoadItemsDropdown()
        {
            var items = _itemService.GetItems();
            Items.DataSource = items;
            Items.DisplayMember = "ItemName";
            Items.ValueMember = "ItemID";
            Items.SelectedIndex = -1;
            Items.SelectedIndexChanged += cbItems_SelectedIndexChanged;
            dgvAgents.DataSource = null; // Clear the grid initially
        }

        private void LoadAgentsDropdown()
        {
            var agents = _agentService.GetAgents();
            Agents.DataSource = agents;
            Agents.ValueMember = "AgentID";
            Agents.SelectedIndex = -1;
            Agents.SelectedIndexChanged += cbAgents_SelectedIndexChanged;
            Agents.DisplayMember = "AgentName";
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Items.SelectedIndex == -1)
            {
                dgvAgents.DataSource = null;
                return;
            }

            int selectedItemId = (int)Items.SelectedValue;
            var orders = _orderService.GetOrders();
            var agentsWhoPurchased = orders
                .Where(o => o.OrderDetails.Any(od => od.ItemID == selectedItemId))
                .Select(o => new
                {
                    AgentName = o.Agent != null ? o.Agent.AgentName : "Unknown Agent",
                    OrderDate = o.OrderDate,
                    TotalQuantity = o.OrderDetails
                        .Where(od => od.ItemID == selectedItemId)
                        .Sum(od => od.Quantity)
                })
                .Distinct()
                .ToList();

            MessageBox.Show($"Found {agentsWhoPurchased.Count} agents who purchased item ID {selectedItemId}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (var agent in agentsWhoPurchased)
            {
                MessageBox.Show($"Agent: {agent.AgentName}, Date: {agent.OrderDate}, Quantity: {agent.TotalQuantity}", "Debug Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dgvAgents.DataSource = null;
            dgvAgents.DataSource = agentsWhoPurchased;
            dgvAgents.Refresh();

            if (dgvItems.Columns["ItemName"] != null)
                dgvItems.Columns["ItemName"].HeaderText = "Item Name";
            if (dgvItems.Columns["Quantity"] != null)
                dgvItems.Columns["Quantity"].HeaderText = "Quantity";
            if (dgvItems.Columns["UnitAmount"] != null)
                dgvItems.Columns["UnitAmount"].HeaderText = "Unit Amount";
            if (dgvItems.Columns["Total"] != null)
                dgvItems.Columns["Total"].HeaderText = "Total";
        }

        private void cbAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Agents.SelectedIndex == -1)
            {
                dgvItems.DataSource = null;
                return;
            }

            try
            {
                // Test with a simple data source
                var testData = new List<object>
                {
                    new { ItemName = "Test Item", Quantity = 1, UnitAmount = 1.00, Total = 1.00 }
                };
                dgvItems.DataSource = null;
                dgvItems.DataSource = testData;
                dgvItems.Refresh();

                // Debug visibility and size
                MessageBox.Show($"dgvItems Visible: {dgvItems.Visible}, Size: {dgvItems.Size.Width}x{dgvItems.Size.Height}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error binding data to dgvItems: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dgvItems.Columns["ItemName"] != null)
                dgvItems.Columns["ItemName"].HeaderText = "Item Name";
            if (dgvItems.Columns["Quantity"] != null)
                dgvItems.Columns["Quantity"].HeaderText = "Quantity";
            if (dgvItems.Columns["UnitAmount"] != null)
                dgvItems.Columns["UnitAmount"].HeaderText = "Unit Amount";
            if (dgvItems.Columns["Total"] != null)
                dgvItems.Columns["Total"].HeaderText = "Total";
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            var itemForm = new ItemForm();
            itemForm.ShowDialog();
        }

        private void btnAgents_Click(object sender, EventArgs e)
        {
            var agentForm = new AgentForm();
            agentForm.ShowDialog();
        }   

        private void btnOrders_Click(object sender, EventArgs e)
        {
            var orderForm = new OrderForm();
            orderForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void dgvAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
