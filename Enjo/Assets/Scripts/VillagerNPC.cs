using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class VillagerNPC : MonoBehaviour
{
    public NavMeshAgent NavMesh;
    public Animator VillagerAnimater;
    public float distance;
    public bool InRange;
    public Transform CurrentTarget;
    public Transform[] Waypoints;
    // Start is called before the first frame update
    void Start()
    {
        VillagerAnimater = GetComponent<Animator>();
        NavMesh = GetComponent<NavMeshAgent>();
        CurrentTarget = Waypoints[Random.Range(0, Waypoints.Length)];
        VillagerAnimater.SetBool("Walking", true);
    }

    // Update is called once per frame
    void Update()
    {
        NavMesh.destination = CurrentTarget.transform.position;
        distance = Vector3.Distance(transform.position, CurrentTarget.transform.position);
        
        if (distance < 4) 
        {
            VillagerAnimater.SetBool("Walking", false);
            StartCoroutine(NewCurrentTarget());
            NewCurrentTarget();
        }
    }
    IEnumerator NewCurrentTarget() 
    {
        yield return new WaitForSeconds(2);
        VillagerAnimater.SetBool("Walking", true);
        CurrentTarget = Waypoints[Random.Range(0, Waypoints.Length)];
    }
}
