using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject circlePrefab;
    public float respawn = 1.0f;
    private Vector3 screenbounds;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startspawn());
        screenbounds = Camera.main.ScreenToWorldPoint(new Vector3(Camera.main.transform.position.x + 15, Camera.main.transform.position.y, Camera.main.transform.position.z + 15));
    }


    private void spawnEnemy()
    {
        //Vector3 viewPos = transform.position;
        //viewPos.x = Mathf.Clamp(viewPos.x, screenbounds.x, screenbounds.x * -1);
        //viewPos.z = Mathf.Clamp(viewPos.z, screenbounds.z, screenbounds.z * -1);
        //GameObject a = Instantiate(circlePrefab);
        //a.transform.position = new Vector3(viewPos.x, 2, viewPos.z);
        GameObject a = Instantiate(circlePrefab);
        a.transform.position = new Vector3(Random.Range(screenbounds.x, -screenbounds.x), 3, Random.Range(screenbounds.z, -screenbounds.z));
    }

    // Update is called once per frame
    IEnumerator startspawn()
    {
        while(true)
        {
            yield return new WaitForSeconds(respawn);
            spawnEnemy();
        }
    }
}
