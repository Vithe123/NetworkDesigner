using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformacionEntreEscenas : MonoBehaviour
{
    public static InformacionEntreEscenas instancia;

    # region InputFieldDatosHogar
    public string numPisos;
    public string largo;
    public string ancho;
    public string alto;

    private string numPisosPrefsName = "NumPisos";
    private string largoPrefsName = "Largo";
    private string anchoPrefsName = "Ancho";
    private string altoPrefsName = "Alto";
    #endregion

    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
            LoadData();
        }
        else
        {
            if (instancia != this)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnDestroy()
    {
        SaveData();
    }

    private void SaveData()
    {
        PlayerPrefs.SetString(numPisosPrefsName, numPisos);
        PlayerPrefs.SetString(largoPrefsName, largo);
        PlayerPrefs.SetString(anchoPrefsName, ancho);
        PlayerPrefs.SetString(altoPrefsName, alto);
    }

    private void LoadData()
    {
        numPisos = PlayerPrefs.GetString(numPisosPrefsName, "0");
        largo = PlayerPrefs.GetString(largoPrefsName, "0");
        ancho = PlayerPrefs.GetString(anchoPrefsName, "0");
        alto = PlayerPrefs.GetString(altoPrefsName, "0");
    }
}
