using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _rb;
    public Transform rotator;
    public Transform tower;

    public float rotationSpeed;
    public float movementSpeed;

    

    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        movementSpeed += Input.mouseScrollDelta.y / 4;
        
        //movement
        float radialMovement = Input.GetAxis("Horizontal");
        float vericalMovement = Input.GetAxis("Vertical");

        _rb.rotation -= radialMovement * rotationSpeed;
        _rb.position -=  (Vector2) ((vericalMovement * movementSpeed / 100) * transform.up);
        //rotator.transform.localPosition = new Vector2(0, -0.0625f);
        

    }
}
