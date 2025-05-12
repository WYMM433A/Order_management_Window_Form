using System.Windows.Forms;

namespace ODM.UI
{
    partial class ItemForm
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
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.getItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblItemName
            // 
            this.lblItemName.Location = new System.Drawing.Point(24, 74);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(80, 20);
            this.lblItemName.TabIndex = 0;
            this.lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(104, 74);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(200, 22);
            this.txtItemName.TabIndex = 1;
            // 
            // lblSize
            // 
            this.lblSize.Location = new System.Drawing.Point(24, 104);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(80, 20);
            this.lblSize.TabIndex = 2;
            this.lblSize.Text = "Size:";
            // 
            // txtSize
            // 
            this.txtSize.Location = new System.Drawing.Point(104, 104);
            this.txtSize.Name = "txtSize";
            this.txtSize.Size = new System.Drawing.Size(200, 22);
            this.txtSize.TabIndex = 3;
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeight = 29;
            this.dgvItems.Location = new System.Drawing.Point(23, 146);
            this.dgvItems.MultiSelect = false;
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 52;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(460, 200);
            this.dgvItems.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 25);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(133, 356);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 25);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(243, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 25);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Item";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(519, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // getItem
            // 
            this.getItem.Location = new System.Drawing.Point(366, 356);
            this.getItem.Name = "getItem";
            this.getItem.Size = new System.Drawing.Size(100, 25);
            this.getItem.TabIndex = 9;
            this.getItem.Text = "Get Item";
            this.getItem.Click += new System.EventHandler(this.getItem_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item ID:";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(104, 36);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(200, 22);
            this.txtItemID.TabIndex = 11;
            // 
            // ItemForm
            // 
            this.ClientSize = new System.Drawing.Size(798, 475);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.getItem);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Name = "ItemForm";
            this.Text = "Manage Items";
            this.Load += new System.EventHandler(this.ItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblItemName, lblSize;
        private TextBox txtItemName, txtSize;
        private DataGridView dgvItems ;
        private Button btnAdd, btnUpdate, btnDelete, btnClear;
        private Button getItem;
        private Label label1;
        private TextBox txtItemID;
    }
}