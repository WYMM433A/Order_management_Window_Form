using System.Windows.Forms;

namespace ODM.UI
{
    partial class mForm
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnAgents = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.cbAgents = new System.Windows.Forms.ComboBox();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.cbItems = new System.Windows.Forms.ComboBox();
            this.dgvBestItems = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestItems)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelSidebar.Controls.Add(this.btnOrders);
            this.panelSidebar.Controls.Add(this.btnAgents);
            this.panelSidebar.Controls.Add(this.btnItems);
            this.panelSidebar.Controls.Add(this.lblWelcome);
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(250, 676);
            this.panelSidebar.TabIndex = 0;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(53, 312);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(130, 44);
            this.btnOrders.TabIndex = 10;
            this.btnOrders.Text = "Manage Orders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnAgents
            // 
            this.btnAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgents.ForeColor = System.Drawing.Color.White;
            this.btnAgents.Location = new System.Drawing.Point(53, 238);
            this.btnAgents.Name = "btnAgents";
            this.btnAgents.Size = new System.Drawing.Size(130, 44);
            this.btnAgents.TabIndex = 9;
            this.btnAgents.Text = "Manage Agents";
            this.btnAgents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(53, 165);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(130, 44);
            this.btnItems.TabIndex = 8;
            this.btnItems.Text = "Manage Items";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Heebo", 24.19672F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(12, 51);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(215, 60);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.ColumnHeadersHeight = 29;
            this.dgvItems.Location = new System.Drawing.Point(69, 462);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.ReadOnly = true;
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.RowHeadersWidth = 52;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(710, 180);
            this.dgvItems.TabIndex = 7;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // cbAgents
            // 
            this.cbAgents.Font = new System.Drawing.Font("Heebo", 10.03279F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgents.Location = new System.Drawing.Point(635, 405);
            this.cbAgents.Name = "cbAgents";
            this.cbAgents.Size = new System.Drawing.Size(144, 33);
            this.cbAgents.TabIndex = 6;
            this.cbAgents.SelectedIndexChanged += new System.EventHandler(this.cbAgents_SelectedIndexChanged_1);
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.ColumnHeadersHeight = 29;
            this.dgvCustomers.Location = new System.Drawing.Point(69, 197);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersVisible = false;
            this.dgvCustomers.RowHeadersWidth = 52;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(710, 180);
            this.dgvCustomers.TabIndex = 4;
            this.dgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellContentClick);
            // 
            // cbItems
            // 
            this.cbItems.Font = new System.Drawing.Font("Heebo", 10.03279F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbItems.Location = new System.Drawing.Point(635, 145);
            this.cbItems.Name = "cbItems";
            this.cbItems.Size = new System.Drawing.Size(144, 33);
            this.cbItems.TabIndex = 3;
            this.cbItems.SelectedIndexChanged += new System.EventHandler(this.cbItems_SelectedIndexChanged_1);
            // 
            // dgvBestItems
            // 
            this.dgvBestItems.AllowUserToAddRows = false;
            this.dgvBestItems.ColumnHeadersHeight = 29;
            this.dgvBestItems.Location = new System.Drawing.Point(69, 72);
            this.dgvBestItems.MultiSelect = false;
            this.dgvBestItems.Name = "dgvBestItems";
            this.dgvBestItems.ReadOnly = true;
            this.dgvBestItems.RowHeadersVisible = false;
            this.dgvBestItems.RowHeadersWidth = 52;
            this.dgvBestItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBestItems.Size = new System.Drawing.Size(710, 53);
            this.dgvBestItems.TabIndex = 1;
            this.dgvBestItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBestItems_CellContentClick);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Heebo", 14.16393F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(63, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 44);
            this.label3.TabIndex = 15;
            this.label3.Text = "Best Selling Item of this Month";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Heebo", 14.16393F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(63, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 44);
            this.label1.TabIndex = 16;
            this.label1.Text = "List of Agents who purchased the item";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Heebo", 14.16393F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(63, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 44);
            this.label2.TabIndex = 17;
            this.label2.Text = "List of items purchased by the Agent";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.dgvBestItems);
            this.panelMain.Controls.Add(this.cbItems);
            this.panelMain.Controls.Add(this.dgvCustomers);
            this.panelMain.Controls.Add(this.cbAgents);
            this.panelMain.Controls.Add(this.dgvItems);
            this.panelMain.Location = new System.Drawing.Point(248, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(815, 676);
            this.panelMain.TabIndex = 1;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // mForm
            // 
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.panelSidebar);
            this.Controls.Add(this.panelMain);
            this.Name = "mForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Dashboard";
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBestItems)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Label lblWelcome;
        private Panel panelSidebar;
        private Button btnItems;
        private Button btnAgents;
        private Button btnOrders;
        private DataGridView dgvItems;
        private ComboBox cbAgents;
        private DataGridView dgvCustomers;
        private ComboBox cbItems;
        private DataGridView dgvBestItems;
        private Label label3;
        private Label label1;
        private Label label2;
        private Panel panelMain;
    }
}
