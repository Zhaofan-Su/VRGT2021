﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObj : MonoBehaviour
{
    public float moveSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * -moveSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
            Destroy(gameObject);
    }

    public void SpeedChanged(float newSpeed)
    {
        this.moveSpeed = newSpeed;
    }
}
