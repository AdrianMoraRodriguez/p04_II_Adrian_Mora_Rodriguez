using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_notifier : MonoBehaviour
{
    public delegate void ColisionArania2();
    public delegate void ColisionArania1();
    public static event ColisionArania2 OnCollisionArania2;
    public static event ColisionArania1 OnCollisionArania1;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "tipo2") {
            OnCollisionArania2();
        } else if (collision.gameObject.tag == "tipo1") {
            OnCollisionArania1();
        }
    }
}
