using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{


    [Header("Inputs")]
    [SerializeField] private KeyCode _jumpKey= (KeyCode.Space);


    [Header("Physics")]
    [SerializeField] private float _movSpeed = 5f;
    [SerializeField] private float _jumpForce = 5.5f;

    private Vector3 _dir = Vector3.zero;
    private Rigidbody _rb;




    private void Awake()
    {
          _rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {

        _dir.x = Input.GetAxisRaw("Horizontal");
        _dir.z = Input.GetAxisRaw("Vertical");

        if (_dir.sqrMagnitude != 0.0f)
        {
            Movement(_dir);
        }

        if (Input.GetKeyDown(_jumpKey))
        {
            Jump();
        }

    }

    private void Movement(Vector3 dir)
    {
       _rb.MovePosition(transform.position += dir.normalized * _movSpeed * Time.deltaTime);
    
    
    }

    private void Jump()
    {
        _rb.AddForce(transform.up * _jumpForce , ForceMode.Impulse);

    }
    


}
