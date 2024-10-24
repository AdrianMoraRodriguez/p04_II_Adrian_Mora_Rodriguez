using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_t1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objetivo;
    void Start() {
        ej3_notifier.OnCollisionArania2 += MoverHaciaObjetivo;
    }

    // Update is called once per frame
    void MoverHaciaObjetivo() {
        Vector3 direccion = objetivo.transform.position - this.transform.position;
        this.GetComponent<Rigidbody>().AddForce(direccion.normalized * 10, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject == objetivo) {
            this.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
