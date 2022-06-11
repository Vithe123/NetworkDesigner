using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPreguntas : MonoBehaviour
{
    public GameObject Anterior;
    public GameObject Posterior;


    public void ActivarGameObject()
    {
        Anterior.SetActive(false);
        Posterior.SetActive(true);
    }
}
