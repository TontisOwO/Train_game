using UnityEngine;

public class DetectionCheck : MonoBehaviour
{
    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player") && collision.GetComponent<PlayerMovement>().isHiding == false)
        {
            Debug.Log("Marco");
        }
    }
}
