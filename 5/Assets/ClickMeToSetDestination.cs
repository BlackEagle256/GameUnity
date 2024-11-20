using UnityEngine;
using UnityEngine.AI;

public class ClickMeToSetDestination : MonoBehaviour
{
    private NavMeshAgent playerNavMeshAgent;

    void Start()
    {
        // پیدا کردن جسم بازیکن
        GameObject playerGO = GameObject.FindGameObjectWithTag("Player");
        playerNavMeshAgent = playerGO.GetComponent<NavMeshAgent>();
    }

    private void OnMouseDown()
    {
        // تنظیم مقصد بازیکن
        playerNavMeshAgent.SetDestination(transform.position);
    }
}
