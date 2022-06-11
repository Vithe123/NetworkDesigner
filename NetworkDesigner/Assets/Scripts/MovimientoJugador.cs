using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    private new Rigidbody cuerpoRigido;

    public float velocidad = 40f;
    // Start is called before the first frame update
    void Start()
    {
        cuerpoRigido = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject != null)
        {
            gameObject.GetComponent(typeof(CharacterController));
            CharacterController cc = (CharacterController)gameObject.GetComponent(typeof(CharacterController));

            /*
            float rotateSpeed = 10.0f;
            float rotationY = Input.GetAxis("Mouse X") * rotateSpeed;
            transform.Rotate(0, rotationY, 0);*/

            float moveSpeed = 40.0f;
            float dt = Time.deltaTime;
            float dy = 0;
            if (Input.GetKey(KeyCode.Space))
            {
                dy = moveSpeed * dt;
            }
            if (Input.GetKey(KeyCode.LeftShift))
            {
                dy -= moveSpeed * dt;
            }
            float dx = Input.GetAxis("Horizontal") * dt * moveSpeed;
            float dz = Input.GetAxis("Vertical") * dt * moveSpeed;

            cc.Move(transform.TransformDirection(new Vector3(dx, dy, dz)));
        }
        /*
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        if(hor != 0.0f || ver != 0.0f)
        {
            Vector3 dir = transform.forward * ver + transform.right * hor;

            cuerpoRigido.MovePosition(transform.position + dir * velocidad * Time.deltaTime);
        }*/
    }
}
