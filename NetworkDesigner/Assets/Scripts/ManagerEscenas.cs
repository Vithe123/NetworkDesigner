using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerEscenas : MonoBehaviour
{
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public void LoadDatosHogar()
    {
        SceneManager.LoadScene("Preguntas");
    }

    public void LoadModeladoHogar()
    {
        SceneManager.LoadScene("EscenaPrincipal");
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
