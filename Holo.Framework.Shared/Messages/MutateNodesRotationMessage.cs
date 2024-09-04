using System;
using Holo.Framework.Math;

namespace Holo.Framework.Shared.Messages
{
    public class MutateNodesRotationMessage : MutateNodesMessage
    {
        public Vector3 Rotation { get; set; }

        public MutateNodesRotationMessage(Guid[] nodeIds, Vector3 rotation) : base(nodeIds)
        {
            Rotation = rotation;
        }
    }
}