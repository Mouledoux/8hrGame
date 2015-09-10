using UnityEngine;
using System.Collections.Generic;

public class SpawnLane : MonoBehaviour
{
    public List<GameObject> lanes;

    void SpawLane()
    {
        GameObject newLane = lanes[Random.Range(0, lanes.Count)];
        Instantiate(newLane, transform.position + transform.forward * 10, transform.rotation);
        transform.position += transform.forward * 10;
    }

    void OnTriggerEnter(Collider other)
    {
        SpawLane();
    }
}