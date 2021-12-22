using UnityEngine;


using System.Collections;

public class PlayerDamage : MonoBehaviour


{
    

    void OnCollisionEnter(Collision other)


    {
        if (other.gameObject.tag == "Damage")
        {
            GetComponent<Animation>();
            Destroy(gameObject);
        }


    }


}
