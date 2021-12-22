using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hanging : MonoBehaviour
{
   void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(2);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
