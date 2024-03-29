using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class CubePlacer : MonoBehaviour
{
    private Grid grid;
    public GameObject Pilar;
    public GameObject LastHit;

    [SerializeField]
    private float dx;

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
        if (Input.GetMouseButton(0))
        {
                if (Physics.Raycast(ray, out hitInfo))
                {
                    BoxCollider bc = hitInfo.collider as BoxCollider;
                    //LastHit = hitInfo.transform.gameObject;
                    collision = hitInfo.point;
                    if (bc.tag != "Pilar")
                    {
                        PlaceCubeNear(hitInfo.point);
                    }
                }
        }
        if (Input.GetMouseButton(1))
        {
            if (Physics.Raycast(ray, out hitInfo))
            {
                BoxCollider bc = hitInfo.collider as BoxCollider;
                if (bc != null)
                {
                    if (bc.tag == "Pilar")
                    {
                        Destroy(bc.gameObject);
                    }
                }
            }
        }
    }

    private void PlaceCubeNear(Vector3 clickPoint)
    {
        GameObject Pilares = Instantiate(Pilar) as GameObject;
        Vector3 finalPosition = grid.GetNearestPointOnGrid(clickPoint);
        Pilares.transform.position = finalPosition;
    }
}
