using System.Windows.Forms;

namespace ODM.UI
{
    partial class AgentForm
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
            this.lblAgentID = new System.Windows.Forms.Label();
            this.txtAgentID = new System.Windows.Forms.TextBox();
            this.btnGet = new System.Windows.Forms.Button();
            this.lblAgentName = new System.Windows.Forms.Label();
            this.txtAgentName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dgvAgents = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAgentID
            // 
            this.lblAgentID.Font = new System.Drawing.Font("Heebo", 10.03279F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentID.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblAgentID.Location = new System.Drawing.Point(35, 70);
            this.lblAgentID.Name = "lblAgentID";
            this.lblAgentID.Size = new System.Drawing.Size(97, 25);
            this.lblAgentID.TabIndex = 0;
            this.lblAgentID.Text = "Agent ID:";
            this.lblAgentID.Click += new System.EventHandler(this.lblAgentID_Click);
            // 
            // txtAgentID
            // 
            this.txtAgentID.Font = new System.Drawing.Font("Heebo", 8.852459F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentID.Location = new System.Drawing.Point(169, 65);
            this.txtAgentID.Name = "txtAgentID";
            this.txtAgentID.Size = new System.Drawing.Size(129, 30);
            this.txtAgentID.TabIndex = 1;
            // 
            // btnGet
            // 
            this.btnGet.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnGet.Font = new System.Drawing.Font("Heebo", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGet.ForeColor = System.Drawing.Color.White;
            this.btnGet.Location = new System.Drawing.Point(455, 125);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(120, 40);
            this.btnGet.TabIndex = 2;
            this.btnGet.Text = "Get Agent";
            this.btnGet.UseVisualStyleBackColor = false;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // lblAgentName
            // 
            this.lblAgentName.Font = new System.Drawing.Font("Heebo", 10.03279F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgentName.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblAgentName.Location = new System.Drawing.Point(35, 136);
            this.lblAgentName.Name = "lblAgentName";
            this.lblAgentName.Size = new System.Drawing.Size(141, 24);
            this.lblAgentName.TabIndex = 3;
            this.lblAgentName.Text = "Agent Name:";
            // 
            // txtAgentName
            // 
            this.txtAgentName.Font = new System.Drawing.Font("Heebo", 8.852459F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgentName.Location = new System.Drawing.Point(169, 135);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.Size = new System.Drawing.Size(200, 30);
            this.txtAgentName.TabIndex = 4;
            // 
            // lblAddress
            // 
            this.lblAddress.Font = new System.Drawing.Font("Heebo", 10.03279F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.lblAddress.Location = new System.Drawing.Point(341, 63);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(96, 32);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Heebo", 8.852459F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(455, 62);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 30);
            this.txtAddress.TabIndex = 6;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // dgvAgents
            // 
            this.dgvAgents.ColumnHeadersHeight = 29;
            this.dgvAgents.Location = new System.Drawing.Point(23, 197);
            this.dgvAgents.MultiSelect = false;
            this.dgvAgents.Name = "dgvAgents";
            this.dgvAgents.ReadOnly = true;
            this.dgvAgents.RowHeadersVisible = false;
            this.dgvAgents.RowHeadersWidth = 52;
            this.dgvAgents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgents.Size = new System.Drawing.Size(645, 140);
            this.dgvAgents.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdd.Font = new System.Drawing.Font("Heebo", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(23, 364);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Agent";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Heebo", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(190, 364);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update Agent";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnDelete.Font = new System.Drawing.Font("Heebo", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(373, 364);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete Agent";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnClear.Font = new System.Drawing.Font("Heebo", 8.262295F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(548, 364);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 40);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.label3.Font = new System.Drawing.Font("Heebo", 11.80328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "Get Agent Details By ID";
            // 
            // AgentForm
            // 
            this.ClientSize = new System.Drawing.Size(702, 433);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAgentID);
            this.Controls.Add(this.txtAgentID);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.lblAgentName);
            this.Controls.Add(this.txtAgentName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.dgvAgents);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Name = "AgentForm";
            this.Text = "Manage Agents";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblAgentID, lblAgentName, lblAddress;
        private TextBox txtAgentID, txtAgentName, txtAddress;
        private DataGridView dgvAgents;
        private Button btnGet, btnAdd, btnUpdate, btnDelete, btnClear;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private Label label3;
    }
}