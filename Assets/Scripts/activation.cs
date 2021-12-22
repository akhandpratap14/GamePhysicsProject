using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activation : MonoBehaviour
{



    public GameObject trap;
    private void OnTriggerEnter(Collider other)
    {
        trap.GetComponent<Animation>().Play("spike");
    }
}
