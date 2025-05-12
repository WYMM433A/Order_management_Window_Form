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
    public partial class OrderForm : Form
    {
        private readonly OrderService _orderService;
        private readonly AgentService _agentService;
        private readonly ItemService _itemService;
        private List<OrderDetail> _orderDetails;

        public OrderForm()
        {
            // Instantiate dependencies manually
            var dbContext = new AppDbContext();
            var orderRepository = new OrderRepository(dbContext);
            var agentRepository = new AgentRepository(dbContext);
            var itemRepository = new ItemRepository(dbContext);
            _orderService = new OrderService(orderRepository, agentRepository, itemRepository);
            _agentService = new AgentService(agentRepository);
            _itemService = new ItemService(itemRepository);

            _orderDetails = new List<OrderDetail>();

            InitializeComponent();
            LoadOrders();
            LoadAgentsDropdown();
            LoadItemsDropdown();
            LoadFilterAgentsDropdown(); 
        }

        private void LoadOrders(int? agentId = null)
        {
            List<Order> orders;
            if (agentId.HasValue)
            {
                orders = _orderService.GetOrdersByAgent(agentId.Value);
            }
            else
            {
                orders = _orderService.GetOrders();
            }

            dgvOrders.DataSource = orders.Select(o => new
            {
                o.OrderID,
                o.OrderDate,
                AgentName = o.Agent.AgentName
            }).ToList();

            if (dgvOrders.Columns["OrderID"] != null)
                dgvOrders.Columns["OrderID"].HeaderText = "Order ID";
            if (dgvOrders.Columns["OrderDate"] != null)
                dgvOrders.Columns["OrderDate"].HeaderText = "Order Date";
            if (dgvOrders.Columns["AgentName"] != null)
                dgvOrders.Columns["AgentName"].HeaderText = "Agent Name";

            if (orders == null || orders.Count == 0)
            {
                MessageBox.Show("No orders found. Please add some orders.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadAgentsDropdown()
        {
            var agents = _agentService.GetAgents();
            cbAgent.DataSource = agents;
            cbAgent.DisplayMember = "AgentName";
            cbAgent.ValueMember = "AgentID";
            cbAgent.SelectedIndex = -1;
        }

        private void LoadFilterAgentsDropdown()
        {
            var agents = _agentService.GetAgents();
            cbFilterAgent.DataSource = agents;
            cbFilterAgent.DisplayMember = "AgentName";
            cbFilterAgent.ValueMember = "AgentID";
            cbFilterAgent.SelectedIndex = -1;
        }

        private void LoadItemsDropdown()
        {
            var items = _itemService.GetItems();
            cbItem.DataSource = items;
            cbItem.DisplayMember = "ItemName";
            cbItem.ValueMember = "ItemID";
            cbItem.SelectedIndexChanged += cbItem_SelectedIndexChanged;
        }

        private void LoadOrderDetails()
        {
            dgvOrderDetails.DataSource = null;
            dgvOrderDetails.DataSource = _orderDetails.Select(od =>
            {
                var item = _itemService.GetItemById(od.ItemID); // Fetch the Item explicitly
                return new
                {
                    ItemName = item?.ItemName ?? "Unknown Item",
                    Quantity = od.Quantity,
                    UnitPrice = item?.UnitPrice ?? 0.00m, // Fetch UnitPrice from Item
                    Total = od.Quantity * (item?.UnitPrice ?? 0.00m) // Calculate Total
                };
            }).ToList();

            if (dgvOrderDetails.Columns["ItemName"] != null)
                dgvOrderDetails.Columns["ItemName"].HeaderText = "Item Name";
            if (dgvOrderDetails.Columns["Quantity"] != null)
                dgvOrderDetails.Columns["Quantity"].HeaderText = "Quantity";
            if (dgvOrderDetails.Columns["UnitAmount"] != null)
                dgvOrderDetails.Columns["UnitAmount"].HeaderText = "Unit Amount";
            if (dgvOrderDetails.Columns["Total"] != null)
                dgvOrderDetails.Columns["Total"].HeaderText = "Total";
        }

        private void cbItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbItem.SelectedIndex != -1)
            {
                var selectedItem = (Item)cbItem.SelectedItem;
                lblUnitPriceValue.Text = selectedItem.UnitPrice.ToString("F2");
            }
            else
            {
                lblUnitPriceValue.Text = "0.00";
            }
        }

        private void ClearForm()
        {
            txtOrderID.Text = string.Empty;
            dtpOrderDate.Value = DateTime.Today;
            cbAgent.SelectedIndex = -1;
            _orderDetails.Clear();
            LoadOrderDetails();
            cbItem.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            lblUnitPriceValue.Text = string.Empty;
            dgvOrders.ClearSelection();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderID.Text.Trim(), out int orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var order = _orderService.GetOrderById(orderId);
                if (order == null)
                {
                    MessageBox.Show("Order not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearForm();
                    return;
                }

                dtpOrderDate.Value = order.OrderDate;
                cbAgent.SelectedValue = order.AgentID;
                _orderDetails = order.OrderDetails.ToList();
                LoadOrderDetails();
                MessageBox.Show($"Order retrieved: ID {order.OrderID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            int? agentId = null;

            // Check if AgentID is provided
            if (!string.IsNullOrWhiteSpace(txtFilterAgentID.Text) && int.TryParse(txtFilterAgentID.Text.Trim(), out int filterAgentId))
            {
                var agent = _agentService.GetAgentById(filterAgentId);
                if (agent == null)
                {
                    MessageBox.Show("Agent not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                agentId = filterAgentId;
            }
            // Otherwise, check if an agent is selected in the ComboBox
            else if (cbFilterAgent.SelectedIndex != -1)
            {
                agentId = (int)cbFilterAgent.SelectedValue;
            }

            LoadOrders(agentId);
        }

        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            cbFilterAgent.SelectedIndex = -1;
            txtFilterAgentID.Text = string.Empty;
            LoadOrders();
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            if (cbItem.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an item.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(txtQuantity.Text.Trim(), out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity greater than zero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!decimal.TryParse(lblUnitPriceValue.Text.Trim(), out decimal unitAmount) || unitAmount <= 0)
            {
                MessageBox.Show("Please enter a valid unit amount greater than zero.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var orderDetail = new OrderDetail
            {
                ItemID = (int)cbItem.SelectedValue,
                Quantity = quantity,
                
            };

            _orderDetails.Add(orderDetail);
            LoadOrderDetails();
            cbItem.SelectedIndex = -1;
            txtQuantity.Text = string.Empty;
            lblUnitPriceValue.Text = "0.00";
        }

        private void btnRemoveDetail_Click(object sender, EventArgs e)
        {
            if (dgvOrderDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order detail to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRowIndex = dgvOrderDetails.SelectedRows[0].Index;
            _orderDetails.RemoveAt(selectedRowIndex);
            LoadOrderDetails();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbAgent.SelectedIndex == -1)
                    throw new ArgumentException("Please select an agent.");
                if (_orderDetails.Count == 0)
                    throw new ArgumentException("Please add at least one order detail.");

                var order = new Order
                {
                    OrderDate = dtpOrderDate.Value,
                    AgentID = (int)cbAgent.SelectedValue,
                    OrderDetails = _orderDetails.ToList()
                };

                _orderService.AddOrder(order);
                LoadOrders();
                ClearForm();
                MessageBox.Show("Order added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderID.Text.Trim(), out int orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (cbAgent.SelectedIndex == -1)
                    throw new ArgumentException("Please select an agent.");
                if (_orderDetails.Count == 0)
                    throw new ArgumentException("Please add at least one order detail.");

                var order = new Order
                {
                    OrderID = orderId,
                    OrderDate = dtpOrderDate.Value,
                    AgentID = (int)cbAgent.SelectedValue,
                    OrderDetails = _orderDetails.ToList()
                };

                _orderService.UpdateOrder(order);
                LoadOrders();
                ClearForm();
                MessageBox.Show("Order updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtOrderID.Text.Trim(), out int orderId))
            {
                MessageBox.Show("Please enter a valid Order ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete the order with ID {orderId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                _orderService.DeleteOrder(orderId);
                LoadOrders();
                ClearForm();
                MessageBox.Show("Order deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load_1(object sender, EventArgs e)
        {

        }

    }
}
