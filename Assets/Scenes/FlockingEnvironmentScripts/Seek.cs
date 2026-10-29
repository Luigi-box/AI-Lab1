using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
public class FollowTarget : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    void Seek(Vector3 des)
    {
        agent.destination = des;
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = target.transform.position - transform.position;
        float lookAhead = targetDir.magnitude / agent.speed;
        Seek(target.transform.position + target.transform.forward * lookAhead);
        // Flee for evasion

        //Seek();
    }
}
