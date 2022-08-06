
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoCamara : MonoBehaviour
{
    private Transform camara;
    private float horizontal;
    private float vertical;
    private float angulo;


    // Start is called before the first frame update
    void Start()
    {
        camara = transform.Find("Camara");
        Cursor.lockState = CursorLockMode.Locked; //el cursor no se salga del juego
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Mouse X");
        vertical = Input.GetAxis("Mouse Y");
        if (horizontal != 0)
        {
            transform.Rotate(Vector3.up * horizontal * 5);
        }
        if (vertical != 0)
        {
            //camara.Rotate(Vector3.left * vertical * 5);
            angulo = (camara.localEulerAngles.x - vertical * 5 + 360) % 360;
            if (angulo > 180)
            {
                angulo -= 360;
            }
            angulo = Mathf.Clamp(angulo, -80, 80);

            camara.localEulerAngles = Vector3.right * angulo;
        }
    }
}