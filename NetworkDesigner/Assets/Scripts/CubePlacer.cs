using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlacer : MonoBehaviour
{
    private Grid grid;
    public GameObject Pilar;
    public GameObject LastHit;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    // Update is called once per frame
    private void Update()
    {
        Vector3 collision = Vector3.zero;
        RaycastHit hitInfo;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hitInfo))
            {
                LastHit = hitInfo.transform.gameObject;
                collision = hitInfo.point;
                if (LastHit.tag != "Pilar" && LastHit.tag != "PilarC")
                {
                    PlaceCubeNear(hitInfo.point);
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(ray, out hitInfo))
            {
                BoxCollider bc = hitInfo.collider as BoxCollider;
                if (bc != null)
                {
                    Destroy(bc.gameObject);
                }
            }
        }
    }

    private void PlaceCubeNear(Vector3 clickPoint)
    {
        if ((Input.GetAxis("Horizontal") >= -45 && Input.GetAxis("Horizontal") <= 45) || (Input.GetAxis("Horizontal") <= -135 && Input.GetAxis("Horizontal") >= 135))
        {
            GameObject Pilares = Instantiate(Pilar) as GameObject;
            var finalPosition = grid.GetNearestPointOnGrid(clickPoint);
            Pilares.transform.position = finalPosition;
        }
    }

}
