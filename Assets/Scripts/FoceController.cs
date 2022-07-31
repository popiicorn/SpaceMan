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
    }

}