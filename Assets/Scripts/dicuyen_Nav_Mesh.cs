using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class dicuyen_Nav_Mesh : MonoBehaviour
{
    public Transform diem_den;
    NavMeshAgent agent;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        diemden();
    }
    private void diemden()
    {
        if (diem_den != null)
        {
            Vector3 diemseditoi=diem_den.transform.position;
            agent.SetDestination(diemseditoi);
        }
    }
}
