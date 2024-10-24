using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej_tp : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject plane;
    void Start() {
      ej5.OnColisionado += Teleportar;
      plane = GameObject.Find("Plane");
    }

  void Teleportar(GameObject objetoColisionado) {
    Debug.Log("Colisionado con tp: " + objetoColisionado.tag);
    Debug.Log("El plano es: " + plane);
    if (objetoColisionado == this.gameObject) {
      if (plane == null) {
        this.GetComponent<Rigidbody>().MovePosition(new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5)));
      } else {
        Vector3 planeScale = plane.transform.localScale;
        float planeWidth = 10 * planeScale.x;
        float planeHeight = 10 * planeScale.z;
        Vector3 planePosition = plane.transform.position;
        float x = Random.Range(planePosition.x - planeWidth / 2, planePosition.x + planeWidth / 2);
        float z = Random.Range(planePosition.z - planeHeight / 2, planePosition.z + planeHeight / 2);
        this.GetComponent<Rigidbody>().MovePosition(new Vector3(x, 0, z));
      }
    }
  }
}
