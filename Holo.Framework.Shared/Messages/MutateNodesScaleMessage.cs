using System;
using Holo.Framework.Math;

namespace Holo.Framework.Shared.Messages
{
    public class MutateNodesScaleMessage : MutateNodesMessage
    {
        public Vector3 Scale { get; set; }
        
        public MutateNodesScaleMessage(Guid[] nodeIds, Vector3 scale) : base(nodeIds)
        {
            Scale = scale;
        }
    }
}