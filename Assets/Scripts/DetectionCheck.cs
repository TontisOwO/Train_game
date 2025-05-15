using UnityEngine;

public class DetectionCheck : MonoBehaviour
{
    private void OnTriggerStay(Collider collision)
    {
        if (collision.CompareTag("Player") && collision.GetComponent<PlayerMovement>().isHiding == false)
        {
            transform.parent.GetComponent<EnemyScript>().pathFinding.SetDestination(collision.transform.position);
        }
    }
}
