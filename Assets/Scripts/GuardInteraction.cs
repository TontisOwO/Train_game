using UnityEngine;

public class GuardInteraction : MonoBehaviour
{
    public float interactRange = 2f;
    public Transform player;
    public PlayerInventory playerInventory;
    public Vector3 moveDirection = new Vector3(3f, 0f, 0f); // move right
    private bool hasMoved = false;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < interactRange && Input.GetKeyDown(KeyCode.E) && playerInventory.hasBun && !hasMoved)
        {
            transform.position += moveDirection;
            hasMoved = true;
        }
    }
}
