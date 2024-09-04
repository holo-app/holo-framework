using System;

namespace Holo.Framework.Shared.Messages
{
    public abstract class MutateNodesMessage
    {
        public Guid[] NodeIds { get; set; }
        
        protected MutateNodesMessage(Guid[] nodeIds)
        {
            NodeIds = nodeIds;
        }
    }
}