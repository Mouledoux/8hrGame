using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour
{
    public KeyCode m_left = KeyCode.A;
    public KeyCode m_right = KeyCode.D;
    public KeyCode m_jump = KeyCode.Space;

    public float m_speed = 1;

    void Update ()
    {
        transform.position += transform.forward * m_speed * Time.deltaTime;

        if (Input.GetKey(m_left))
        {
            transform.position -= transform.right * Time.deltaTime;
        }

        if (Input.GetKeyDown(m_right))
        {
            transform.position += transform.right * Time.deltaTime;
        }

        m_speed += Time.deltaTime * 0.1f;
	}
}
