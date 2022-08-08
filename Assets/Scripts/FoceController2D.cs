using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoceController2D : MonoBehaviour
{
    private Rigidbody2D rb;
    private float upForce;
    private Vector3 mousePosition;
    private Vector3 objPosition;

    public float force;
    public float power;
    public float rote;

    [SerializeField]
    float LimitSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        upForce = force;
    }

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 10.0f;
            objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            rb.AddForce(new Vector3(objPosition.x * power, upForce, 0));

        }

        if (rb.velocity.magnitude > LimitSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.1f, rb.velocity.y / 1.1f);
        }

        transform.Rotate(new Vector3(0, 0, rote) * Time.deltaTime, Space.World);
    }
}
