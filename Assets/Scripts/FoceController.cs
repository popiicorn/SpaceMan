using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoceController : MonoBehaviour
{
    private Rigidbody rb;
    private int upForce;
    private Vector3 mousePosition;
    private Vector3 objPosition;

    public int force;
    public int power;

    [SerializeField]
    float LimitSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        upForce = force;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            mousePosition.z = 10.0f;
            objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            rb.AddForce(new Vector3(objPosition.x * power, upForce, 0));

        }

        if (rb.velocity.magnitude > LimitSpeed)
        {
            rb.velocity = new Vector3(rb.velocity.x / 1.1f, rb.velocity.y, rb.velocity.z / 1.1f);
        }
    }

}