using UnityEngine;
using System.Collections;

public class BallControl : MonoBehaviour {
    public int speed = 10;
    private Rigidbody rb;
    // Use this for initialization
    void Start () {
        rb.GetComponent<Rigidbody>();
        
    } 
	
	// Update is called once per frame
	void Update () {
       /* if (Input.GetKeyDown(KeyCode.Space)) {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right*10);
        }*/
     
        //建立一個向量變量
        Vector3 dir= Vector3.zero;
         dir.z = Input.acceleration.y;
         dir.x = Input.acceleration.x;
         //箝制加速向量到單位球
         if (dir.sqrMagnitude>1) {
             dir.Normalize();
         }
         //每秒移動10米
         dir *= Time.deltaTime;
        
         gameObject.GetComponent<Rigidbody>().AddForce(dir * speed, ForceMode.Force);
         rb.AddForce(dir * speed, ForceMode.Force);

    }
}
