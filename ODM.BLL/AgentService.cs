using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODM.DAL;

namespace ODM.BLL
{
    public class AgentService
    {
        private readonly AgentRepository _agentRepository;

        public AgentService(AgentRepository agentRepository)
        {
            _agentRepository = agentRepository;
        }

        public List<Agent> GetAgents()
        {
            return _agentRepository.GetAgents();
        }

        public Agent GetAgentById(int agentId)
        {
            return _agentRepository.GetAgentById(agentId);
        }

        public void AddAgent(Agent agent)
        {
            if (agent == null)
                throw new ArgumentNullException(nameof(agent));
            if (string.IsNullOrWhiteSpace(agent.AgentName))
                throw new ArgumentException("Agent name cannot be empty.", nameof(agent.AgentName));
            if (string.IsNullOrWhiteSpace(agent.Address))
                throw new ArgumentException("Address cannot be empty.", nameof(agent.Address));

            _agentRepository.AddAgent(agent);
        }

        public void UpdateAgent(Agent agent)
        {
            if (agent == null)
                throw new ArgumentNullException(nameof(agent));
            if (string.IsNullOrWhiteSpace(agent.AgentName))
                throw new ArgumentException("Agent name cannot be empty.", nameof(agent.AgentName));
            if (string.IsNullOrWhiteSpace(agent.Address))
                throw new ArgumentException("Address cannot be empty.", nameof(agent.Address));
            if (_agentRepository.GetAgentById(agent.AgentID) == null)
                throw new ArgumentException("Agent does not exist.", nameof(agent.AgentID));

            _agentRepository.UpdateAgent(agent);
        }

        public void DeleteAgent(int agentId)
        {
            if (_agentRepository.GetAgentById(agentId) == null)
                throw new ArgumentException("Agent does not exist.", nameof(agentId));

            _agentRepository.DeleteAgent(agentId);
        }
    }
}
