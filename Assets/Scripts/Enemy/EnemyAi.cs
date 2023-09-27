using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    private NavMeshAgent agent;
    //public int IndexTarget;
    //public Transform path;//path
    //public bool iswaiting;
    //public bool isfollow;  

    public Transform player;
    int health = 100;
    public Rigidbody bullet;
    public Transform spamer;
    bool isshoot=false;

   
    void Start()
    {
        agent= GetComponent<NavMeshAgent>();


        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 Distance=this.transform.position-player.transform.position;
        Distance.y = 0;
        if (Physics.Linecast(this.transform.position, player.transform.position, out hit, -1))
          {
            if (hit.transform.CompareTag("player"))
            {
                if (Distance.magnitude > 5)
                {
                    this.transform.Translate(Vector3.forward * 2 * Time.deltaTime);
                    this.transform.LookAt(player.transform);
                    isshoot = false;
                }
                else
                {
                    isshoot = true;
                    this.transform.LookAt(player.transform);
                }
            }
        }
        if (health < 1)
        {
            this.gameObject.SetActive(false);
        }
      
    }


    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(1);
        if(isshoot)
        {

        Rigidbody clone;
        clone = (Rigidbody)Instantiate(bullet, spamer.transform.position, Quaternion.identity);
        clone.velocity = spamer.TransformDirection(Vector3.forward * 1000 * Time.deltaTime);

        }
        StartCoroutine(Shoot());
    }
    //private void /*OnCollisionEnter(*/Collision collision)
    //{
    //    if (collision.gameObject.CompareTag("Bullet"))
    //    {
    //        health -= 20;
    //    }
    //}


}
