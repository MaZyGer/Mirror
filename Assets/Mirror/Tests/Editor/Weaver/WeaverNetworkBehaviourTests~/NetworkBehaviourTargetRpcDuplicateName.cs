using System;
using System.Collections;
using UnityEngine;
using Mirror;

namespace MirrorTest
{
    class NetworkBehaviourTargetRpcDuplicateName : NetworkBehaviour
    {
        [TargetRpc]
        public void TargetRpcCantHaveSameName(NetworkConnection monkeyCon, int abc) {}

        [TargetRpc]
        public void TargetRpcCantHaveSameName(NetworkConnection monkeyCon, int abc, int def) {}
    }
}