using UnityEngine;
using System.Collections;

public class DayNight : MonoBehaviour
{
	void Update ()
    {
        transform.Rotate((Time.deltaTime) ,0 ,0);
	}
}
