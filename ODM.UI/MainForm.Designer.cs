using ODM.DAL;

namespace ODM.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnAgents = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panelMianForm = new System.Windows.Forms.Panel();
            this.dgv_bestItem = new System.Windows.Forms.DataGridView();
            this.orderManagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Agents = new System.Windows.Forms.ComboBox();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Items = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelMianForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bestItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnItems
            // 
            this.btnItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItems.ForeColor = System.Drawing.Color.White;
            this.btnItems.Location = new System.Drawing.Point(47, 156);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(130, 44);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Manage Items";
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnAgents
            // 
            this.btnAgents.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgents.ForeColor = System.Drawing.Color.White;
            this.btnAgents.Location = new System.Drawing.Point(47, 221);
            this.btnAgents.Name = "btnAgents";
            this.btnAgents.Size = new System.Drawing.Size(130, 44);
            this.btnAgents.TabIndex = 2;
            this.btnAgents.Text = "Manage Agents";
            this.btnAgents.Click += new System.EventHandler(this.btnAgents_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.ForeColor = System.Drawing.Color.White;
            this.btnOrders.Location = new System.Drawing.Point(47, 288);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(130, 44);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Manage Orders";
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Heebo", 24.19672F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Location = new System.Drawing.Point(14, 47);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(215, 60);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome!";
            // 
            // panelMianForm
            // 
            this.panelMianForm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelMianForm.Controls.Add(this.lblWelcome);
            this.panelMianForm.Controls.Add(this.btnItems);
            this.panelMianForm.Controls.Add(this.btnAgents);
            this.panelMianForm.Controls.Add(this.btnOrders);
            this.panelMianForm.Location = new System.Drawing.Point(-2, 0);
            this.panelMianForm.Name = "panelMianForm";
            this.panelMianForm.Size = new System.Drawing.Size(250, 676);
            this.panelMianForm.TabIndex = 6;
            // 
            // dgv_bestItem
            // 
            this.dgv_bestItem.AutoGenerateColumns = false;
            this.dgv_bestItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bestItem.DataSource = this.orderManagementDataSetBindingSource;
            this.dgv_bestItem.Location = new System.Drawing.Point(307, 85);
            this.dgv_bestItem.Name = "dgv_bestItem";
            this.dgv_bestItem.RowHeadersWidth = 52;
            this.dgv_bestItem.RowTemplate.Height = 24;
            this.dgv_bestItem.Size = new System.Drawing.Size(711, 53);
            this.dgv_bestItem.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Heebo", 14.16393F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(301, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 44);
            this.label1.TabIndex = 8;
            this.label1.Text = "List of Agents who purchased the item";
            // 
            // Agents
            // 
            this.Agents.Font = new System.Drawing.Font("Heebo", 10.03279F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agents.FormattingEnabled = true;
            this.Agents.Location = new System.Drawing.Point(873, 416);
            this.Agents.Name = "Agents";
            this.Agents.Size = new System.Drawing.Size(144, 33);
            this.Agents.TabIndex = 9;
            // 
            // dgvAgents
            // 
            this.dgvAgents.AutoGenerateColumns = false;
            this.dgvAgents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgents.DataSource = this.orderManagementDataSetBindingSource;
            this.dgvAgents.Location = new System.Drawing.Point(307, 221);
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.RowHeadersWidth = 52;
            this.dgvAgents.RowTemplate.Height = 24;
            this.dgvAgents.Size = new System.Drawing.Size(710, 180);
            this.dgvAgents.TabIndex = 10;
            this.dgvAgents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAgents_CellContentClick);
            // 
            // dgvItems
            // 
            this.dgvItems.AutoGenerateColumns = false;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.DataSource = this.orderManagementDataSetBindingSource;
            this.dgvItems.Location = new System.Drawing.Point(307, 463);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 52;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.Size = new System.Drawing.Size(710, 180);
            this.dgvItems.TabIndex = 13;
            this.dgvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // Items
            // 
            this.Items.Font = new System.Drawing.Font("Heebo", 10.03279F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.FormattingEnabled = true;
            this.Items.Location = new System.Drawing.Point(873, 163);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(144, 33);
            this.Items.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Heebo", 14.16393F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label2.Location = new System.Drawing.Point(301, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "List of items purchased by the Agent";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Heebo", 14.16393F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Location = new System.Drawing.Point(301, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(519, 44);
            this.label3.TabIndex = 14;
            this.label3.Text = "Best Selling Item of this Month";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1071, 673);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.Agents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_bestItem);
            this.Controls.Add(this.panelMianForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMianForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bestItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderManagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnItems;
        private System.Windows.Forms.Button btnAgents;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panelMianForm;
        private System.Windows.Forms.DataGridView dgv_bestItem;
        private System.Windows.Forms.BindingSource orderManagementDataSetBindingSource;
        private System.Windows.Forms.Label label1;
  
        private System.Windows.Forms.ComboBox Agents;
        private System.Windows.Forms.DataGridView dgvAgents;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.ComboBox Items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}