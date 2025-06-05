using UnityEngine;
using Unity.Netcode;
public class PlayerNetwork : NetworkBehaviour
{
    public float moveSpeed = 3f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void Update()
    {
        if (!IsOwner) return;

        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")) * moveSpeed * Time.deltaTime;
    }
}
