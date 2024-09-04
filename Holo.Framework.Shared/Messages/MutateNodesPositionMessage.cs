using System;
using Holo.Framework.Math;

namespace Holo.Framework.Shared.Messages
{
    public class MutateNodesPositionMessage : MutateNodesMessage
    {
        public Vector3 Position { get; set; }

        public MutateNodesPositionMessage(Guid[] nodeIds, Vector3 position) : base(nodeIds)
        {
            Position = position;
        }
    }
}