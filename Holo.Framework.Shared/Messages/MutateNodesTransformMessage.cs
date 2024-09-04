using System;
using Holo.Framework.Math;

namespace Holo.Framework.Shared.Messages
{
    public class MutateNodesTransformMessage : MutateNodesMessage
    {
        public Vector3 Position { get; set; }
        public Vector3 Rotation { get; set; }
        public Vector3 Scale { get; set; }
        
        public MutateNodesTransformMessage(Guid[] nodeIds, Vector3 position, Vector3 rotation, Vector3 scale) : base(nodeIds)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }
    }
}