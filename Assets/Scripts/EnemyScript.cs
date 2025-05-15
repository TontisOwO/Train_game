using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] BoxCollider visionBox;
    public NavMeshAgent pathFinding;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        visionBox = transform.GetChild(0).GetComponent<BoxCollider>();
        pathFinding = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider collision)
    {

    }
}
