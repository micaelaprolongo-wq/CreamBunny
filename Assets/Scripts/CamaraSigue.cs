using System.Collections;
using System.Collections.Generic;
using Mono.CompilerServices.SymbolWriter;
using UnityEngine;

public class CamaraSigue : MonoBehaviour
{
    public Transform objetivo;
    public Vector3 offset = new Vector3(0f, 0f, -10f);
    public float suavizado = 5f;

    void LateUpdate()
    {
        if (objetivo != null)
    {
        Vector3 posicionDeseada = objetivo.position + offset;
        transform.position = Vector3.Lerp(transform.position, posicionDeseada, suavizado * Time.deltaTime);
    }
}
}
