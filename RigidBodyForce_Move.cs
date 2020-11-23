using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

//Rigid Body physics with collisions (make sure freeze rotation (rigidbody component) on all axis!!!)
//Add force, similar to accelerating in a car or starting to run and using gravity, drag, etc. to slow to a stop.
//Can simulate sliding on ice, floating on through space or in water, on wheels.
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
        rb.AddForce(direction * speed);
    }
}
