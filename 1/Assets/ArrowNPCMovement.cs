using UnityEngine;
using UnityEngine.AI;

public class ArrowNPCMovement : MonoBehaviour
{
    public GameObject targetGo;
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        HeadForDestination();
    }

    private void HeadForDestination()
    {
        Vector3 destination = targetGo.transform.position;
        navMeshAgent.SetDestination(destination);
    }
}
