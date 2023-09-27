using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movecontroler : MonoBehaviour
{
    public float movspeed;

    public float ro;
    private Rigidbody rb;
    Vector3 vi = new Vector3(0, 90, 0);
    CharacterController controller;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();   
    }
    private void Update()
    {
        float Ho = Input.GetAxis("Horizontal");
        float ve = Input.GetAxis("Vertical");
        //Vector3 meve = new Vector3(Ho, 0, ve);
        //gameObject.transform.Translate(meve * movspeed * Time.deltaTime, Space.Self);


        Vector3 movement = new Vector3(Ho, 0, ve);
        movement *= movspeed;
        controller.SimpleMove(movement);

        //controller.Move(movement);



        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    rb.AddForce(movspeed * Vector3.forward);
        //}
        //





        if (Input.GetKey(KeyCode.E))
        {
            xoay();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            xoaytra();
        }    


    }
    public void xoay()
    {
        gameObject.transform.Rotate(vi * ro * Time.deltaTime);

    }
    public void xoaytra()
    {
        Quaternion xoaytrai = Quaternion.Euler(0, -1*ro, 0);
        transform.rotation= transform.rotation*xoaytrai;
    }    





}
