using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTerreno : MonoBehaviour
{
    public static SpawnTerreno spawnT;

    public GameObject Contenedor;
    public GameObject Terreno;
    public GameObject Pilar;

    private int _numPisos;
    private float _largo;
    private float _ancho;
    private float _alto;
    public float TamPilar = 1.0f;

    private string numPisos;
    private string largo;
    private string ancho;
    private string alto;
    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        StringToInt();
        SpawnearTerreno();
        AgrandarPilar();
        GenerarBarda();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void StringToInt()
    {
        bool success = int.TryParse(numPisos, out _numPisos);
        _largo = float.Parse(largo);
        _ancho = float.Parse(ancho);
        _alto = float.Parse(alto);
    }

    public void SpawnearTerreno()
    {
        GameObject terreno_medidas = Instantiate(Terreno) as GameObject;
        terreno_medidas.transform.position = new Vector3(0, 0, 0);
        terreno_medidas.transform.localScale = new Vector3(_ancho, 1, _largo);  // x 
    }

    private void LoadData()
    {
        numPisos = InformacionEntreEscenas.instancia.numPisos;
        largo = InformacionEntreEscenas.instancia.largo;
        ancho = InformacionEntreEscenas.instancia.ancho;
        alto = InformacionEntreEscenas.instancia.alto;
    }
    private void AgrandarPilar()
    {
        Pilar.transform.position = new Vector3(0, 0, 0);
        Pilar.transform.localScale = new Vector3(1.0f, _alto*10.0f, 1.0f);  // x z 
        Contenedor.SetActive(false);
    }

    private void GenerarBarda()
    {
        //Estandarizar medidas para bardas.
    }
}
