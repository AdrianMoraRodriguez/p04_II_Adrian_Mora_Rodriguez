using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
      //Mover el cubo con awsd
      float h = Input.GetAxis("Horizontal");
      float v = Input.GetAxis("Vertical");
	    if (h != 0 || v != 0) {
        transform.Translate(h * speed * Time.deltaTime, 0, v * speed * Time.deltaTime);
			}
    }
}
