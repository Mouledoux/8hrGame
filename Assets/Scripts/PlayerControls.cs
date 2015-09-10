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
    public AudioSource crash;

    public Rigidbody rb;

    float looseTimer, looseDelay;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score.text = "0";
        looseDelay = 3.0f;
    }

    void Update ()
    {
        rb.AddForce(transform.forward * m_speed * 100);

        if (Input.GetKey(m_left))
        {
            rb.AddTorque(transform.up * -Time.deltaTime * 1000 * m_speed);
        }

        if (Input.GetKey(m_right))
        {
            rb.AddTorque(transform.up * +Time.deltaTime * 1000 * m_speed);
        }

        score.text = ((int)Vector3.Distance(Vector3.zero, transform.position)).ToString() ;
        m_speed += Time.deltaTime * 0.03f;

        if (m_speed > 1.01 && Vector3.Distance(rb.velocity, Vector3.zero) < 0.1)
        {
            looseTimer += Time.deltaTime;
        }

        else
        {
            looseTimer = 0;
        }

        if (looseTimer > looseDelay)
        {
            print("What a looser");
        }

        //print(rb.velocity);
	}

    void OnCollisionEnter(Collision other)
    {
        crash.Play();
    }
}
