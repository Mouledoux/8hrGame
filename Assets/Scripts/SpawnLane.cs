using UnityEngine;
using System.Collections.Generic;

public class SpawnLane : MonoBehaviour
{
    public List<GameObject> lanes;
    GameObject lastLane;

    void SpawLane()
    {
        GameObject t;

        do
        {
            t = lanes[Random.Range(0, lanes.Count)];
        } while (t == lastLane);

        lastLane = t;

        if (Random.Range(0, 2) == 0)
        {
            Instantiate(lastLane,
           transform.position + transform.forward * 90,
           new Quaternion(0, 180, 0, 0));
        }
        else
        {
            Instantiate(lastLane,
           transform.position + transform.forward * 90,
           transform.rotation);
        }

        transform.position += transform.forward * 10;
    }

    void OnTriggerEnter(Collider other)
    {
        SpawLane();
    }
}