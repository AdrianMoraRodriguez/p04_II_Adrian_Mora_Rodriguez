using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ej7 : MonoBehaviour {
  public TMP_Text recompensa;
    void Start() {
      ej5.OnRecompensa += IncrementarRecompensa;
    }

    // Update is called once per frame
    void IncrementarRecompensa(int puntuacion) {
      if (recompensa != null) {
        recompensa.text = "Recompensa: " + (puntuacion / 100);
    } else {
        Debug.LogError("No se ha asignado el campo 'recompensa' en el Inspector.");
    }
    }
}
