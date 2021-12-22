using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Spike;
    private void OnTriggerEnter(Collider other)
    {
        Spike.GetComponent<Animation>().Play("spike2");

    }
}
