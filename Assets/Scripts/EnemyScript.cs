using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] BoxCollider visionBox;
    [SerializeField] NavMeshAgent pathFinding;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        visionBox = transform.GetChild(0).GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collision)
    {

    }
}
