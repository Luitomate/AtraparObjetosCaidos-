using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    public Text textoPuntuacion;
    public int puntuacion = 0;

    void OnTriggerEnter(Collider otro)
    {
        if (otro.CompareTag("ObjetoCaido"))
        {
            puntuacion++;
            textoPuntuacion.text = "Puntuación: " + puntuacion;
            Destroy(otro.gameObject);
        }
    }
}
