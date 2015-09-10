using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerControls : MonoBehaviour
{
    public KeyCode m_left = KeyCode.A;
    public KeyCode m_right = KeyCode.D;
    public KeyCode m_jump = KeyCode.Space;

    public float m_speed = 1;

    public Text score;

    public Rigidbody rb;

    public bool started;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score.text = "0";
    }
    void Update ()
    {
        rb.AddForce(transform.forward * m_speed * 100);

        if (Input.GetKey(m_left))
        {
            rb.AddTorque(transform.up * -Time.deltaTime * 1000);
        }

        if (Input.GetKey(m_right))
        {
            rb.AddTorque(transform.up * +Time.deltaTime * 1000);
        }

        score.text = ((int)Vector3.Distance(Vector3.zero, transform.position)).ToString() ;
        m_speed += Time.deltaTime * 0.01f;

        if (rb.velocity.)

        print(rb.velocity);
	}
}
