using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej4_notifier : MonoBehaviour
{
    public delegate void AproximacionCubo();
    public static event AproximacionCubo OnAproximacionCubo;
    public GameObject objetoReferencia;
    public float distanciaMinima = 1.0f;
    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
      float distancia = Vector3.Distance(transform.position, objetoReferencia.transform.position);
      if(distancia < distanciaMinima) {
        Debug.Log("Cubo cerca");
        OnAproximacionCubo();
      }
    }
}
