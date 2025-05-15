using UnityEngine;

public class CinnamonBunPickup : MonoBehaviour
{
    public float pickupRange = 2f;
    public Transform player;
    public PlayerInventory playerInventory;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < pickupRange && Input.GetKeyDown(KeyCode.E))
        {
            playerInventory.hasBun = true;
            Destroy(gameObject);
        }
    }
}
