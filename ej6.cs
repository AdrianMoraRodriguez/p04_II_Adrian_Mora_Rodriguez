using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ej6 : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text puntaje;
    void Start() {
      ej5.OnPuntuacion += IncrementarPuntaje;
      if (puntaje != null) {
        puntaje.text = "Puntuacion: 0";
      } else {
        Debug.LogError("No se ha asignado el campo 'puntaje' en el Inspector.");
      }
    }

    // Update is called once per frame
    void IncrementarPuntaje(int puntuacion) {
      if (puntaje != null) {
        puntaje.text = "Puntuacion: " + puntuacion;
    } else {
        Debug.LogError("No se ha asignado el campo 'puntaje' en el Inspector.");
    }
    }
}
