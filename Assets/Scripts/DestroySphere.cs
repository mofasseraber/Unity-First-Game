using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySphere : MonoBehaviour
{
    
    void OnCollisionEnter(Collision col)
    {

        if (col.collider.name == "Sphere")
        {
            Destroy(col.gameObject);
        }
    }
}
