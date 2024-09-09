using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class press : MonoBehaviour
{
    private Rigidbody _rb;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            _rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
    }
}
