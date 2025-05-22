using UnityEngine;
using System.Collections;

public class GuardInteraction : MonoBehaviour
{
    public float interactRange = 2f;
    public Transform player;
    public PlayerInventory playerInventory;
    public Vector3 moveDirection = new Vector3(3f, 0f, 0f); // move right
    public float moveDuration = 2f;

    private bool hasMoved = false;

    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.position);

        if (distance < interactRange && Input.GetKeyDown(KeyCode.E) && playerInventory.hasBun && !hasMoved)
        {
            StartCoroutine(MoveGuard(transform.position, transform.position + moveDirection, moveDuration));
            hasMoved = true;
        }
    }

    IEnumerator MoveGuard(Vector3 startPos, Vector3 endPos, float duration)
    {
        float elapsed = 0f;
        while (elapsed < duration)
        {
            transform.position = Vector3.Lerp(startPos, endPos, elapsed / duration);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.position = endPos;
    }
}
