using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToGoal : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        obstacle = GameObject.FindGameObjectWithTag("obstacle");
        agent = GetComponent<NavMeshAgent>();
        agent.destination = obstacle.transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            print("Test!");
            Destroy(other.gameObject);
            Destroy(transform.gameObject);
        }
    }
}