using UnityEngine;
using UnityEngine.AI;

public class EnemyBehaviour : MonoBehaviour
{
    [SerializeField] private NavMeshAgent agent;
    [SerializeField] private Transform player;
    [SerializeField] private LayerMask isPlayer;
    [SerializeField] private float detectionRange = 5.0f;
    private bool playerInRange;
 
    void Update()
    {
        playerInRange = Physics.CheckSphere(transform.position, detectionRange, isPlayer);

        if (playerInRange) Flee();
        else Seek();
    }

    void Seek()
    {
        agent.SetDestination(player.position);
    }
    
    void Flee()
    {
        Vector3 pos = transform.position;
        agent.SetDestination(pos - (player.position - pos));
    }

}
