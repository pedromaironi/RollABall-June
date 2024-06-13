using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoConstante : MonoBehaviour
{
    public Vector3 direccionMovimiento = new Vector3(12, 0, 0); // Dirección principal del movimiento
    public Vector3 direccionLateral = new Vector3(0, 0, 10); // Dirección lateral del movimiento
    public float velocidad = 5f; // Velocidad del movimiento
    public float distanciaMaxima = 0.1f; 
    public float amplitudLateral = 0.02f;

    private Vector3 posicionInicial;
    private Vector3 posicionObjetivo;
    private float tiempo;

    // Start se llama antes del primer frame update
    void Start()
    {
        posicionInicial = transform.position;
        posicionObjetivo = posicionInicial + (direccionMovimiento.normalized * distanciaMaxima);
        tiempo = 0;
    }

    // Update se llama una vez por frame
    void Update()
    {
        tiempo += Time.deltaTime * velocidad;

        // Movimiento hacia adelante y hacia atrás
        float distancia = 0.100f;
        Vector3 nuevaPosicion = posicionInicial + (direccionMovimiento.normalized * distancia);

        // Movimiento lateral en bucle
        float offsetLateral = Mathf.Sin(tiempo) * amplitudLateral;
        nuevaPosicion += direccionLateral.normalized * offsetLateral;

        transform.position = nuevaPosicion;
    }
}