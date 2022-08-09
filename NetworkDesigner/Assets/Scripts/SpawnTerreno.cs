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
    private float TamPilar = 1.0f;

    private string numPisos;
    private string largo;
    private string ancho;
    private string alto;

    private void Awake()
    {
        
    }

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

    public float TamanoStandar()
    {
        return TamPilar;
    }

    public float enviarLargo()
    {
        return ((_alto*10)/2.0f)+0.5f;
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
        terreno_medidas.transform.localScale = new Vector3(_ancho*10, 1, _largo*10);  // x 
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
        Pilar.transform.localScale = new Vector3(TamPilar, _alto*10, TamPilar);  // x z 
        //Contenedor.SetActive(false);
    }

    private void GenerarBarda()
    {
        //Estandarizar medidas para bardas.
        float x = _ancho*5;
        float z = _largo*5;
        Vector3 finalPosition;
        GameObject Pilares = Instantiate(Pilar) as GameObject;

        for (float i = x*-1.0f; i <= x; i++)
        {
            Pilares = Instantiate(Pilar) as GameObject;
            finalPosition = new Vector3(i, enviarLargo(), z);
            Pilares.transform.position = finalPosition;

            Pilares = Instantiate(Pilar) as GameObject;
            finalPosition = new Vector3(i, enviarLargo(), z*-1.0f);
            Pilares.transform.position = finalPosition;
        }

        for (float i = z * -1.0f; i <= z; i++)
        {
            Pilares = Instantiate(Pilar) as GameObject;
            finalPosition = new Vector3(x, enviarLargo(), i);
            Pilares.transform.position = finalPosition;

            Pilares = Instantiate(Pilar) as GameObject;
            finalPosition = new Vector3(x * -1.0f, enviarLargo(), i);
            Pilares.transform.position = finalPosition;
        }
    }

    
}
