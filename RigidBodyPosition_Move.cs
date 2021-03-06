﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Rigid Body physics with collisions (make sure freeze rotation (rigidbody component) on all axis!!!)
//Like translate, but includes all physics
//If you accelerate to fast then collision detection is ignored

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 10.0f;
    public Rigidbody rb;
    public Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() //Ran once per frame, better to dect player input
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }
    private void FixedUpdate() //USE EVERY TIME WORKING WITH PHYSICS, Ran every physical step: i.e. (0,1,...) or multiple times per frame
    {
        moveCharacter(movement);
    }
    void moveCharacter(Vector2 direction)
    {
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
}
