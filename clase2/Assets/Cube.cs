using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    Vector3 velocity = new Vector3(0.2f, 0.5f, 0);
    Vector3 gravity = new Vector3(0, -0.01f, 0);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        velocity += gravity;
        transform.position += velocity;

        if (transform.position.y <= -5 )
        {
            Vector3 aux = transform.position;
            aux.y = -5;
            transform.position = aux;
            velocity.y *= -.9f;
            
            // velocity.y *= -.7f;
            velocity.x *= .9f;
        }
        if (transform.position.y >= 5)
        {
            Vector3 aux = transform.position;
            aux.y = 5;
            transform.position = aux;
            velocity.y *= -.9f;
            velocity.x *= .9f;

        }
        if( transform.position.x > 13)
        {
            Vector3 aux = transform.position;
            aux.x = 13;
            transform.position = aux;
            velocity.x *= -.9f;
            velocity.y *= .9f;

        }

        if (transform.position.x < -13)
        {
            Vector3 aux = transform.position;
            aux.x = -13;
            transform.position = aux;
            velocity.x *= -.9f;
            velocity.y *= .9f;
        }
    }
}
