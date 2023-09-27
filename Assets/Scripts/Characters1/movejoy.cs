using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class movejoy : MonoBehaviour
{

    NavMeshAgent agent;
    public float speed = 3f;
    public float tocdoxoay = 10f;

  public VariableJoystick joystick;
     public Canvas canvas;
    private bool dangnhanjoystick=false;
    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        
    }
    private void Start()
    {
      

    }
    private void Update()
    {
        Vector3 targetDirection = new Vector3(joystick.Direction.x, 0, joystick.Direction.y);
        if (targetDirection!=Vector3.zero)
        { 
        MoveToDirection(targetDirection);
        
        }    

    }
   
    public void MoveToDirection(Vector3 hoan)////////////////////////////////////////
    {
        RotateToDirection(hoan);
       agent.Move(transform.forward * speed * Time.deltaTime);
    }
    public void RotateToDirection(Vector3 huongxoay)////////////////////
    {
        Quaternion targetQuaternion = Quaternion.LookRotation(huongxoay, Vector3.up);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetQuaternion, tocdoxoay * Time.deltaTime);
    }
}
        