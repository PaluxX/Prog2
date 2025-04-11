using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    [SerializeField] private float _movSpeed = 5f;
    [SerializeField] private float _xAxis, _yAxis;

    private Vector3 _dir = Vector3.zero;


    private void Update()
    {

        _dir.x = Input.GetAxisRaw("Horizontal");
        _dir.z = Input.GetAxisRaw("Vertical");

        if (_dir.sqrMagnitude != 0.0f)
        {
            Movement(_dir);
        }

    }

    private void Movement(Vector3 dir)
    {
        transform.position += dir.normalized * _movSpeed * Time.deltaTime;
    
    
    }


    


}
