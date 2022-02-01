using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphere : MonoBehaviour
{
    private Rigidbody Sphere;
    RigidCube player;
    public int points;
    // Start is called before the first frame update
    void Start()
    {
        Sphere = this.GetComponent<Rigidbody>();
        player = FindObjectOfType<RigidCube>();
    }
    
    void OnCollisionEnter(Collision col)
    {

        if (col.collider.name == "rigidcube")
        {
            Destroy(gameObject);
            points++;
            player.points += points;
        }
    }
    
    void Update()
    {
        Destroy(this.gameObject,2);
    }
}
