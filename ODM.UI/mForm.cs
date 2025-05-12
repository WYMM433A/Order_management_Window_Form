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
    public partial class mForm : Form
    {
        private readonly User _currentUser;
        private readonly OrderService _orderService;
        private readonly AgentService _agentService;
        private readonly ItemService _itemService;

        public mForm(User currentUser)
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
            try
            {
                var bestItems = _orderService.GetBestItems();
                var data = bestItems.Select(x => new
                {
                    ItemName = x.Item.ItemName,
                    TotalQuantity = x.TotalQuantity
                }).ToList();


                dgvBestItems.DataSource = null;
                dgvBestItems.DataSource = data;
                dgvBestItems.Refresh();

                if (dgvBestItems.Columns["ItemName"] != null)
                    dgvBestItems.Columns["ItemName"].HeaderText = "Item Name";
                if (dgvBestItems.Columns["TotalQuantity"] != null)
                    dgvBestItems.Columns["TotalQuantity"].HeaderText = "Total Quantity Sold";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading best-selling items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadItemsDropdown()
        {
            try
            {
                var items = _itemService.GetItems();
                cbItems.DataSource = items;
                cbItems.DisplayMember = "ItemName";
                cbItems.ValueMember = "ItemID";
                cbItems.SelectedIndex = -1;
                cbItems.SelectedIndexChanged += cbItems_SelectedIndexChanged;
                dgvCustomers.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading items dropdown: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAgentsDropdown()
        {
            try
            {
                var agents = _agentService.GetAgents();
                cbAgents.DataSource = agents;
                cbAgents.DisplayMember = "AgentName";
                cbAgents.ValueMember = "AgentID";
                cbAgents.SelectedIndex = -1;
                cbAgents.SelectedIndexChanged += cbAgents_SelectedIndexChanged;
                dgvItems.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading agents dropdown: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItems.SelectedIndex == -1)
            {
                dgvCustomers.DataSource = null;
                return;
            }

            try
            {
                int selectedItemId = (int)cbItems.SelectedValue;
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

                MessageBox.Show($"Found {agentsWhoPurchased.Count} agents who purchased the item.", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);


                dgvCustomers.DataSource = null;
                dgvCustomers.DataSource = agentsWhoPurchased;
                dgvCustomers.Refresh();

                if (dgvCustomers.Columns["AgentName"] != null)
                    dgvCustomers.Columns["AgentName"].HeaderText = "Agent Name";
                if (dgvCustomers.Columns["OrderDate"] != null)
                    dgvCustomers.Columns["OrderDate"].HeaderText = "Order Date";
                if (dgvCustomers.Columns["TotalQuantity"] != null)
                    dgvCustomers.Columns["TotalQuantity"].HeaderText = "Total Quantity";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in cbItems_SelectedIndexChanged: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAgents.SelectedIndex == -1)
            {
                dgvItems.DataSource = null;
                return;
            }

            try
            {
                int selectedAgentId = (int)cbAgents.SelectedValue;
                var orders = _orderService.GetOrdersByAgent(selectedAgentId);
                var itemsPurchased = orders
                    .SelectMany(o => o.OrderDetails)
                    .Select(od => new
                    {
                        ItemName = od.Item != null ? od.Item.ItemName : "Unknown Item",
                        Quantity = od.Quantity,
                        UnitPrice = od.Item.UnitPrice, // Fetch from Item
                        Total = od.Quantity * od.Item.UnitPrice
                    })
                    .Distinct()
                    .ToList();

                MessageBox.Show($"Found {itemsPurchased.Count} items purchased by the agent", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvItems.DataSource = null;
                dgvItems.DataSource = itemsPurchased;
                dgvItems.Refresh();

                if (dgvItems.Columns["ItemName"] != null)
                    dgvItems.Columns["ItemName"].HeaderText = "Item Name";
                if (dgvItems.Columns["Quantity"] != null)
                    dgvItems.Columns["Quantity"].HeaderText = "Quantity";
                if (dgvItems.Columns["UnitAmount"] != null)
                {
                    dgvItems.Columns["UnitAmount"].HeaderText = "Unit Amount";
                    dgvItems.Columns["UnitAmount"].DefaultCellStyle.Format = "F2";
                }
                if (dgvItems.Columns["Total"] != null)
                {
                    dgvItems.Columns["Total"].HeaderText = "Total";
                    dgvItems.Columns["Total"].DefaultCellStyle.Format = "F2";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in cbAgents_SelectedIndexChanged: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbAgents_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbItems_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dgvBestItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
