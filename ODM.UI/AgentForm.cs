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
    public partial class AgentForm : Form
    {
        private readonly AgentService _agentService;
        public AgentForm()
        {
            var dbContext = new AppDbContext();
            var agentRepository = new AgentRepository(dbContext);
            _agentService = new AgentService(agentRepository);
            InitializeComponent();
            LoadAgents();
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadAgents()
        {
            var agents = _agentService.GetAgents();
            dgvAgents.DataSource = agents;

            // Set column headers
            if (dgvAgents.Columns["AgentID"] != null)
                dgvAgents.Columns["AgentID"].HeaderText = "Agent ID";
            if (dgvAgents.Columns["AgentName"] != null)
                dgvAgents.Columns["AgentName"].HeaderText = "Agent Name";
            if (dgvAgents.Columns["Address"] != null)
                dgvAgents.Columns["Address"].HeaderText = "Address";

            if (agents == null || agents.Count == 0)
            {
                MessageBox.Show("No agents found in the database. Please add some agents.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ClearForm()
        {
            txtAgentID.Text = string.Empty;
            txtAgentName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            dgvAgents.ClearSelection();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAgentID.Text.Trim(), out int agentId))
            {
                MessageBox.Show("Please enter a valid Agent ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var agent = _agentService.GetAgentById(agentId);
                if (agent == null)
                {
                    MessageBox.Show("Agent not found.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearForm();
                    return;
                }

                txtAgentName.Text = agent.AgentName;
                txtAddress.Text = agent.Address;
                MessageBox.Show($"Agent retrieved: {agent.AgentName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving agent: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var agent = new Agent
                {
                    AgentName = txtAgentName.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                _agentService.AddAgent(agent);
                LoadAgents();
                ClearForm();
                MessageBox.Show("Agent added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding agent: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAgentID.Text.Trim(), out int agentId))
            {
                MessageBox.Show("Please enter a valid Agent ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var agent = new Agent
                {
                    AgentID = agentId,
                    AgentName = txtAgentName.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                _agentService.UpdateAgent(agent);
                LoadAgents();
                ClearForm();
                MessageBox.Show("Agent updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating agent: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAgentID.Text.Trim(), out int agentId))
            {
                MessageBox.Show("Please enter a valid Agent ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to delete the agent with ID {agentId}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;

            try
            {
                _agentService.DeleteAgent(agentId);
                LoadAgents();
                ClearForm();
                MessageBox.Show("Agent deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting agent: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAgentID_Click(object sender, EventArgs e)
        {

        }
    }
}
