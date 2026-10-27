using System;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    private Camera cam;

    private float orgZ;
    private void Start()
    {
        cam = GetComponent<Camera>();
        orgZ = cam.transform.position.z;    

    }
    // Update is called once per frame
    

    private void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length == 0)
        {
            return;
        }
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

        MoveCamera(players);

    }

    private void MoveCamera(GameObject[] players)
    {
        GetCenter(players);
        cam.transform.position = GetCenter(players) + new Vector3(0, 0, orgZ);
        

    }

    Vector3 GetCenter(GameObject[] players)
    {
        Vector3 center = new Vector3(0, 0, 0);
        foreach (GameObject player in players)
        {
            center += player.transform.position;
        }
        
        center /= players.Length;
        center = new Vector3(center.x, center.y, orgZ);
        return center;
    }
}
