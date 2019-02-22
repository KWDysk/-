using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics : MonoBehaviour
{

    //  重力のやつ
    public Vector3 localGravity;

    private Rigidbody rd;

    // Start is called before the first frame update
    void Start()
    {
        rd = this.GetComponent<Rigidbody>();
        rd.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        setLocalGravity();
    }

    void setLocalGravity()
    {
        rd.AddForce(localGravity, ForceMode.Acceleration);
    }
}
