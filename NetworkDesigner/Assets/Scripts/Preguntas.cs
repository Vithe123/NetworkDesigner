using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Preguntas : MonoBehaviour
{
    public GameObject terreno;

    private string numPisos;
    private string largo;
    private string ancho;
    private string alto;

    private int _numPisos;
    private float _largo;
    private float _ancho;
    private float _alto;


    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        StringToInt();
        SpawnearTerreno();
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

    private void StringToInt()
    {
        _numPisos = int.Parse(numPisos);
        _largo = float.Parse(largo);
        _ancho = float.Parse(ancho);
        _alto = float.Parse(alto);
    }

    public void SpawnearTerreno()
    {
        GameObject terreno_medidas = Instantiate(terreno) as GameObject;
        terreno_medidas.transform.position = new Vector3(0, 0, 0);
        terreno_medidas.transform.localScale = new Vector3(_ancho, 1, _largo);  // x z 

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
