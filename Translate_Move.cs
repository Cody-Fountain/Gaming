using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Moves an object along an axis (Joy stick or Keyboard)    IGNORES ALL PHYSICS!!!
//                                                    so not the best for player movement
//                                            Use to swipe between panels or add points to a score

public class Translate_Move : MonoBehaviour
{   
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveCharacter(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"))); //Keyboard/Joystick
    }
    void moveCharacter(Vector2 direction)
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
