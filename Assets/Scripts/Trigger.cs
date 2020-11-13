using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    [SerializeField] private Transform theDoor;
    private float startX;
    private bool isOpen;

    private void Start()
    {
        startX = theDoor.position.x;
    }

    private void Update()
    {
        if (isOpen && theDoor.position.x < startX + 1f)
        {
            theDoor.position += theDoor.right * Time.deltaTime;
        }
        
        if (isOpen == false && theDoor.position.x > startX)
        {
            theDoor.position -= theDoor.right * Time.deltaTime;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            isOpen = true;   
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            isOpen = false;   
        }
    }
}
