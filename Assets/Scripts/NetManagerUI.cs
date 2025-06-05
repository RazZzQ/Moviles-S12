using UnityEngine;
using Unity.Netcode;
public class NetManagerUI : NetworkBehaviour
{
    private void OnGUI()
    {
        if (!NetworkManager.Singleton.IsClient && !NetworkManager.Singleton.IsServer)
        {
            if (GUI.Button(new Rect(10, 10, 120, 30), "Iniciar Host"))
            {
                NetworkManager.Singleton.StartHost();
            }

            if (GUI.Button(new Rect(10, 50, 120, 30), "Iniciar Cliente"))
            {
                NetworkManager.Singleton.StartClient();
            }

            if (GUI.Button(new Rect(10, 90, 120, 30), "Iniciar Servidor"))
            {
                NetworkManager.Singleton.StartServer();
            }
        }
    }
}
