using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 10f;

    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        transform.Translate(movimiento, 0, 0);

        // Limitar el movimiento de la canasta a los bordes de la pantalla
        float posX = Mathf.Clamp(transform.position.x, -8f, 8f);
        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
