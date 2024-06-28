using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoCaido : MonoBehaviour
{
    public float velocidad = 5f;  // Velocidad de caída

    void Update()
    {
        // Mover el objeto hacia abajo a una velocidad constante
        transform.Translate(Vector3.down * velocidad * Time.deltaTime);

        // Fijar la posición en z = 0 para evitar desplazamientos en el eje z
        Vector3 posicionActual = transform.position;
        posicionActual.z = 0;
        transform.position = posicionActual;

        // Destruir el objeto si sale de la pantalla
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
