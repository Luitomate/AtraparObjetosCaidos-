using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjetos : MonoBehaviour
{
    public GameObject objetoPrefab;  // Prefab del objeto caído
    public float intervaloGeneracion = 1f;  // Intervalo de tiempo entre cada generación de objetos
    public float rangoX = 8f;  // Rango en el eje X donde los objetos pueden aparecer

    void Start()
    {
        // Llamar a la función GenerarObjeto repetidamente
        InvokeRepeating("GenerarObjeto", 1f, intervaloGeneracion);
    }

    void GenerarObjeto()
    {
        // Calcular una posición aleatoria en el eje X dentro del rango especificado
        float posX = Random.Range(-rangoX, rangoX);
        // Crear una nueva posición con el valor de y = 4.33 y z = 0
        Vector3 posicion = new Vector3(posX, 4.33f, 0f);
        // Instanciar el objeto caído en la posición calculada
        Instantiate(objetoPrefab, posicion, Quaternion.identity);
    }
}
