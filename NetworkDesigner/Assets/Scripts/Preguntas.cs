using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preguntas : MonoBehaviour
{
    private int numPisos;
    private float largo;
    private float ancho;
    private float alto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pisos(int p)
    {
        numPisos = p;
    }

    public void ObtenerAltura(int s)
    {
        alto = s;
    }

    public void ObtenerAnchura(int s)
    {
        ancho = s;
    }

    public void ObtenerLargo(int s)
    {
        largo = s;
    }
}
