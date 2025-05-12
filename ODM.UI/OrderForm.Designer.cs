using System.Windows.Forms;

namespace ODM.UI
{
    partial class OrderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblOrderID = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblAgent = new System.Windows.Forms.Label();
            this.cbAgent = new System.Windows.Forms.ComboBox();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.dgvOrderDetails = new System.Windows.Forms.DataGridView();
            this.lblItem = new System.Windows.Forms.Label();
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblUnitAmount = new System.Windows.Forms.Label();
            this.btnAddDetail = new System.Windows.Forms.Button();
            this.btnRemoveDetail = new System.Windows.Forms.Button();
            this.lblFilterAgent = new System.Windows.Forms.Label();
            this.cbFilterAgent = new System.Windows.Forms.ComboBox();
            this.lblFilterAgentID = new System.Windows.Forms.Label();
            this.txtFilterAgentID = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblUnitPriceValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderID
            // 
            this.lblOrderID.Location = new System.Drawing.Point(20, 20);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(80, 20);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID:";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(100, 20);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(100, 22);
            this.txtOrderID.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(210, 20);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(80, 25);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get Order";
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.Location = new System.Drawing.Point(20, 50);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(80, 20);
            this.lblOrderDate.TabIndex = 3;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(100, 50);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 22);
            this.dtpOrderDate.TabIndex = 4;
            // 
            // lblAgent
            // 
            this.lblAgent.Location = new System.Drawing.Point(20, 80);
            this.lblAgent.Name = "lblAgent";
            this.lblAgent.Size = new System.Drawing.Size(80, 20);
            this.lblAgent.TabIndex = 5;
            this.lblAgent.Text = "Agent:";
            // 
            // cbAgent
            // 
            this.cbAgent.Location = new System.Drawing.Point(100, 80);
            this.cbAgent.Name = "cbAgent";
            this.cbAgent.Size = new System.Drawing.Size(200, 24);
            this.cbAgent.TabIndex = 6;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.Location = new System.Drawing.Point(20, 110);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(100, 20);
            this.lblOrderDetails.TabIndex = 7;
            this.lblOrderDetails.Text = "Order Details:";
            // 
            // dgvOrderDetails
            // 
            this.dgvOrderDetails.ColumnHeadersHeight = 29;
            this.dgvOrderDetails.Location = new System.Drawing.Point(20, 130);
            this.dgvOrderDetails.MultiSelect = false;
            this.dgvOrderDetails.Name = "dgvOrderDetails";
            this.dgvOrderDetails.ReadOnly = true;
            this.dgvOrderDetails.RowHeadersVisible = false;
            this.dgvOrderDetails.RowHeadersWidth = 52;
            this.dgvOrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetails.Size = new System.Drawing.Size(460, 100);
            this.dgvOrderDetails.TabIndex = 8;
            // 
            // lblItem
            // 
            this.lblItem.Location = new System.Drawing.Point(20, 240);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(80, 20);
            this.lblItem.TabIndex = 9;
            this.lblItem.Text = "Item:";
            // 
            // cbItem
            // 
            this.cbItem.Location = new System.Drawing.Point(100, 240);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(100, 24);
            this.cbItem.TabIndex = 10;
            // 
            // lblQuantity
            // 
            this.lblQuantity.Location = new System.Drawing.Point(210, 240);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(80, 20);
            this.lblQuantity.TabIndex = 11;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(290, 240);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(50, 22);
            this.txtQuantity.TabIndex = 12;
            // 
            // lblUnitAmount
            // 
            this.lblUnitAmount.Location = new System.Drawing.Point(350, 240);
            this.lblUnitAmount.Name = "lblUnitAmount";
            this.lblUnitAmount.Size = new System.Drawing.Size(100, 20);
            this.lblUnitAmount.TabIndex = 13;
            this.lblUnitAmount.Text = "Unit Amount:";
            // 
            // btnAddDetail
            // 
            this.btnAddDetail.Location = new System.Drawing.Point(100, 270);
            this.btnAddDetail.Name = "btnAddDetail";
            this.btnAddDetail.Size = new System.Drawing.Size(80, 25);
            this.btnAddDetail.TabIndex = 15;
            this.btnAddDetail.Text = "Add Detail";
            this.btnAddDetail.Click += new System.EventHandler(this.btnAddDetail_Click);
            // 
            // btnRemoveDetail
            // 
            this.btnRemoveDetail.Location = new System.Drawing.Point(190, 270);
            this.btnRemoveDetail.Name = "btnRemoveDetail";
            this.btnRemoveDetail.Size = new System.Drawing.Size(100, 25);
            this.btnRemoveDetail.TabIndex = 16;
            this.btnRemoveDetail.Text = "Remove Detail";
            this.btnRemoveDetail.Click += new System.EventHandler(this.btnRemoveDetail_Click);
            // 
            // lblFilterAgent
            // 
            this.lblFilterAgent.Location = new System.Drawing.Point(20, 300);
            this.lblFilterAgent.Name = "lblFilterAgent";
            this.lblFilterAgent.Size = new System.Drawing.Size(80, 20);
            this.lblFilterAgent.TabIndex = 17;
            this.lblFilterAgent.Text = "Filter by Agent:";
            // 
            // cbFilterAgent
            // 
            this.cbFilterAgent.Location = new System.Drawing.Point(100, 300);
            this.cbFilterAgent.Name = "cbFilterAgent";
            this.cbFilterAgent.Size = new System.Drawing.Size(100, 24);
            this.cbFilterAgent.TabIndex = 18;
            // 
            // lblFilterAgentID
            // 
            this.lblFilterAgentID.Location = new System.Drawing.Point(210, 300);
            this.lblFilterAgentID.Name = "lblFilterAgentID";
            this.lblFilterAgentID.Size = new System.Drawing.Size(80, 20);
            this.lblFilterAgentID.TabIndex = 19;
            this.lblFilterAgentID.Text = "Agent ID:";
            // 
            // txtFilterAgentID
            // 
            this.txtFilterAgentID.Location = new System.Drawing.Point(290, 300);
            this.txtFilterAgentID.Name = "txtFilterAgentID";
            this.txtFilterAgentID.Size = new System.Drawing.Size(50, 22);
            this.txtFilterAgentID.TabIndex = 20;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(350, 300);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(60, 25);
            this.btnFilter.TabIndex = 21;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(420, 300);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(80, 25);
            this.btnClearFilter.TabIndex = 22;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.ColumnHeadersHeight = 29;
            this.dgvOrders.Location = new System.Drawing.Point(20, 330);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.RowHeadersVisible = false;
            this.dgvOrders.RowHeadersWidth = 52;
            this.dgvOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrders.Size = new System.Drawing.Size(460, 70);
            this.dgvOrders.TabIndex = 23;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 410);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "Add Order";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 410);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 25;
            this.btnUpdate.Text = "Update Order";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(240, 410);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(350, 410);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblUnitPriceValue
            // 
            this.lblUnitPriceValue.AutoSize = true;
            this.lblUnitPriceValue.Location = new System.Drawing.Point(444, 248);
            this.lblUnitPriceValue.Name = "lblUnitPriceValue";
            this.lblUnitPriceValue.Size = new System.Drawing.Size(40, 16);
            this.lblUnitPriceValue.TabIndex = 28;
            this.lblUnitPriceValue.Text = "value";
            // 
            // OrderForm
            // 
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.lblUnitPriceValue);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblAgent);
            this.Controls.Add(this.cbAgent);
            this.Controls.Add(this.lblOrderDetails);
            this.Controls.Add(this.dgvOrderDetails);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.cbItem);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblUnitAmount);
            this.Controls.Add(this.btnAddDetail);
            this.Controls.Add(this.btnRemoveDetail);
            this.Controls.Add(this.lblFilterAgent);
            this.Controls.Add(this.cbFilterAgent);
            this.Controls.Add(this.lblFilterAgentID);
            this.Controls.Add(this.txtFilterAgentID);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.dgvOrders);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Name = "OrderForm";
            this.Text = "Manage Orders";
            this.Load += new System.EventHandler(this.OrderForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblOrderID, lblOrderDate, lblAgent, lblOrderDetails, lblItem, lblQuantity, lblUnitAmount, lblFilterAgent, lblFilterAgentID;
        private TextBox txtOrderID, txtQuantity, txtFilterAgentID;
        private DateTimePicker dtpOrderDate;
        private ComboBox cbAgent, cbItem, cbFilterAgent;
        private DataGridView dgvOrders, dgvOrderDetails;
        private Button btnGet, btnAddDetail, btnRemoveDetail, btnFilter, btnClearFilter, btnAdd, btnUpdate, btnDelete, btnClear;
        private Label lblUnitPriceValue;
    }



}
