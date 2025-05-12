using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODM.DAL
{
    public class AgentRepository
    {
        private readonly AppDbContext _context;

        public AgentRepository(AppDbContext context)
        {
            _context = context;
        }

        public void AddAgent(Agent agent)
        {
            _context.Agents.Add(agent);
            _context.SaveChanges();
        }

        public List<Agent> GetAgents()
        {
            return _context.Agents.ToList();
        }

        public Agent GetAgentById(int agentId)
        {
            return _context.Agents.FirstOrDefault(a => a.AgentID == agentId);
        }

        public void UpdateAgent(Agent agent)
        {
            var existingAgent = _context.Agents.FirstOrDefault(a => a.AgentID == agent.AgentID);
            if (existingAgent != null)
            {
                existingAgent.AgentName = agent.AgentName;
                existingAgent.Address = agent.Address;
                _context.SaveChanges();
            }
        }

        public void DeleteAgent(int agentId)
        {
            var agent = _context.Agents.FirstOrDefault(a => a.AgentID == agentId);
            if (agent != null)
            {
                _context.Agents.Remove(agent);
                _context.SaveChanges();
            }
        }
    }
}
