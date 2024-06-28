using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorObjetos : MonoBehaviour
{
    public GameObject objetoPrefab;  // Prefab del objeto ca�do
    public float intervaloGeneracion = 1f;  // Intervalo de tiempo entre cada generaci�n de objetos
    public float rangoX = 8f;  // Rango en el eje X donde los objetos pueden aparecer

    void Start()
    {
        // Llamar a la funci�n GenerarObjeto repetidamente
        InvokeRepeating("GenerarObjeto", 1f, intervaloGeneracion);
    }

    void GenerarObjeto()
    {
        // Calcular una posici�n aleatoria en el eje X dentro del rango especificado
        float posX = Random.Range(-rangoX, rangoX);
        // Crear una nueva posici�n con el valor de y = 4.33 y z = 0
        Vector3 posicion = new Vector3(posX, 4.33f, 0f);
        // Instanciar el objeto ca�do en la posici�n calculada
        Instantiate(objetoPrefab, posicion, Quaternion.identity);
    }
}
