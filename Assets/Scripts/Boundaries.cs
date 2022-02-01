using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector3 screenbounds;

    // Start is called before the first frame update
    void Start()
    {
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x+15, Camera.main.transform.position.y, Camera.main.transform.position.z+15));
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenbounds.x, screenbounds.x * -1);
        viewPos.z = Mathf.Clamp(viewPos.z, screenbounds.z, screenbounds.z * -1);
        transform.position = viewPos;

    }
}
