﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Homing : MonoBehaviour {
    public GameObject target;
    private NavMeshAgent agent;

    
   //追尾のやつ
   
    

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
	// Update is called once per frame
	void Update () {
        agent.destination = target.transform.position;
        
    }
}
