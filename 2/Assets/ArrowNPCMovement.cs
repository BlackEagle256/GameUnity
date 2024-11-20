using UnityEngine;
using UnityEngine.AI;

public class ArrowNPCMovement : MonoBehaviour
{
    public GameObject targetGo; // هدف متحرک
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        HeadForDestination(); // فراخوانی حرکت در هر فریم
    }

    private void HeadForDestination()
    {
        Vector3 destination = targetGo.transform.position; // موقعیت هدف
        navMeshAgent.SetDestination(destination);
    }
}
