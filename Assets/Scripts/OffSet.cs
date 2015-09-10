using UnityEngine;
using System.Collections;

public class OffSet : MonoBehaviour
{

    public GameObject target;
    public Vector3 offset;

    void Start()
    {
        offset = target.transform.position + transform.position;
    }
    
	void Update ()
    {
        transform.position = target.transform.position + offset;
	}
}
