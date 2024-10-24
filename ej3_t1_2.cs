using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej3_t1_2 : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject[] huevosGrupo2;
    void Start()
    {
        ej3_notifier.OnCollisionArania1 += MoverHaciaHuevo;
        huevosGrupo2 = GameObject.FindGameObjectsWithTag("Eggt2");
    }

    void MoverHaciaHuevo() {
        //Encontrar el huevo más cercano
        GameObject huevoCercano = null;
        float distanciaMinima = Mathf.Infinity;
        foreach (GameObject huevo in huevosGrupo2) {
            float distancia = Vector3.Distance(huevo.transform.position, this.transform.position);
            if (distancia < distanciaMinima) {
                huevoCercano = huevo;
                distanciaMinima = distancia;
            }
        }
        Vector3 direccion = huevoCercano.transform.position - this.transform.position;
        this.GetComponent<Rigidbody>().AddForce(direccion.normalized * 10, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Eggt2") {
            this.GetComponent<Renderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }
    }
}
