using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preguntas : MonoBehaviour
{
    private string numPisos;
    private string largo;
    private string ancho;
    private string alto;


    // Start is called before the first frame update
    void Start()
    {
        LoadData();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Pisos(string p)
    {
        numPisos = p;
    }

    public void ObtenerAltura(string s)
    {
        alto = s;
    }

    public void ObtenerAnchura(string s)
    {
        ancho = s;
    }

    public void ObtenerLargo(string s)
    {
        largo = s;
    }

    private void OnDestroy()
    {
        SaveData();
    }

    private void SaveData()
    {
        InformacionEntreEscenas.instancia.numPisos = numPisos;
        InformacionEntreEscenas.instancia.largo = largo;
        InformacionEntreEscenas.instancia.ancho = ancho;
        InformacionEntreEscenas.instancia.alto = alto;
    }

    private void LoadData()
    {
        numPisos = InformacionEntreEscenas.instancia.numPisos;
        largo = InformacionEntreEscenas.instancia.largo;
        ancho = InformacionEntreEscenas.instancia.ancho;
        alto = InformacionEntreEscenas.instancia.alto;
    }
}
