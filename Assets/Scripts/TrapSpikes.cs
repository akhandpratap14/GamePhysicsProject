using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapSpikes : MonoBehaviour
{
    public List<CharacterController> ListCharacters = new List<CharacterController>();

    private void Start()
    {
        ListCharacters.Clear();
    }

    public static bool isTrap(GameObject fpp)
    {
        if (fpp.transform.root.gameObject.GetComponent<TrapSpikes>() == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        CharacterController control = other.gameObject.transform.root.gameObject.GetComponent<CharacterController>();

        if (control != null)
        {
            if (ListCharacters.Contains(control))
            {
                ListCharacters.Add(control);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        CharacterController control = other.gameObject.transform.root.gameObject.GetComponent<CharacterController>();

        if(control != null)
        {
            if(ListCharacters.Contains(control))
            {
                ListCharacters.Remove(control);
            }
        }
    }
}
