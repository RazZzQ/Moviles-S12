using UnityEngine;
using Unity.Netcode;
public class HealthManager : NetworkBehaviour
{
    public NetworkVariable<int> health = new NetworkVariable<int>(100);

    private void Update()
    {
        // Solo el servidor puede aplicar daño
        if (IsServer && Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int amount)
    {
        health.Value -= amount;
        Debug.Log("Daño recibido. Vida actual: " + health.Value);
    }
}
