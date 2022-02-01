using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointCounter : MonoBehaviour
{
    RigidCube player;
    public Text pointText;

    void Start()
    {
        player = FindObjectOfType<RigidCube>();
    }

    // Update is called once per frame
    void Update()
    {
        pointText.text = ("Score:" + player.points);
    }
}
