using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalChecker : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        //rb = GameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision other){
        if(rb.velocity.magnitude<0.1){
            rb.velocity = new Vector3(0,0,50);
        }
    }

    void OnTriggerEnter(Collider other){
        Debug.Log("Player Scores");
    }
}
