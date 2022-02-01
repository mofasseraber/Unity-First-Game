using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidCube : MonoBehaviour
{
    public float force = 500;
    private Rigidbody cube;
    public int points;
    private bool touchStart = false;
    private Vector3 pointA;
    private Vector3 pointB;

    public Transform circle;
    public Transform outerCircle;


    private void Awake()
    {
        cube = this.GetComponent<Rigidbody>();
    }
    private void Update()
    {
 
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 p = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pointA = (new Vector3(p.x, 3, p.z));
            //pointA = (new Vector3(Input.mousePosition.x, 3, Input.mousePosition.y));

            circle.GetComponent<SpriteRenderer>().enabled = true;
            outerCircle.GetComponent<SpriteRenderer>().enabled = true;
            //circle.transform.position = (new Vector3(-7, 3, -3));
            //outerCircle.transform.position = (new Vector3(-7, 3, -3));
            circle.transform.position = pointA;
            outerCircle.transform.position = pointA;
            
        }
        if(Input.GetMouseButton(0))
        {
            touchStart = true;
            Vector3 q = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pointB = (new Vector3(q.x, 3, q.z));
            //pointB= (new Vector3(Input.mousePosition.x, 3, Input.mousePosition.y));
        }
        else
        {
            touchStart = false;
        }
    }

    private void FixedUpdate()
    {
        if (touchStart)
        {
            Vector3 offset = pointB - pointA;
            Vector3 direction = Vector3.ClampMagnitude(offset, 1.0f);
            moveCharacter(direction);
            circle.transform.position = new Vector3(pointA.x + direction.x, 3, pointA.z + direction.z);
        }
        else
        {
            circle.GetComponent<SpriteRenderer>().enabled = false;
            outerCircle.GetComponent<SpriteRenderer>().enabled = false;
            moveCharacter(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
        }

    }

    void moveCharacter(Vector3 direction)
    {
        cube.AddForce(direction * force * Time.deltaTime);
        
        //transform.Translate(direction * Time.deltaTime);
    }
}

//MOVING WITH ADDFORCE*********************************
/*
if (Input.GetKey(KeyCode.UpArrow))
{
    cube.AddForce(new Vector3(0, 0, transform.forward.z) * force * Time.deltaTime);
}
if (Input.GetKey(KeyCode.DownArrow))
{
    cube.AddForce(0, 0, transform.forward.z * -force * Time.deltaTime);
}
if (Input.GetKey(KeyCode.RightArrow))
{
    cube.AddForce(transform.right * force * Time.deltaTime);
}
if (Input.GetKey(KeyCode.LeftArrow))
{
    cube.AddForce(transform.right * -force * Time.deltaTime);
}*/
//ENDING MOVING WITH ADDFORCE*********************************

//MOVING WITH TRANSFORM*********************************
/*
if (Input.GetKey(KeyCode.UpArrow))
{
    transform.Translate(0f, 5f * Time.deltaTime, 0f);
}
if (Input.GetKey(KeyCode.DownArrow))
{
    transform.Translate(0f, -5f * Time.deltaTime, 0f);
}
if (Input.GetKey(KeyCode.RightArrow))
{
    transform.Translate(5f * Vector3.right * Time.deltaTime);
}
if (Input.GetKey(KeyCode.LeftArrow))
{
    transform.Translate(-5f * Time.deltaTime, 0f, 0f);
}
*/
//ENDING MOVING WITH TRANSFORM*********************************