using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlacer : MonoBehaviour
{
    private Grid grid;

    public GameObject Pilar;

    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hitInfo;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hitInfo))
            {
                PlaceCubeNear(hitInfo.point);
            }
        }
    }

    private void PlaceCubeNear(Vector3 clickPoint)
    {
        GameObject Pilares = Instantiate(Pilar) as GameObject;
        var finalPosition = grid.GetNearestPointOnGrid(clickPoint);
        Pilares.transform.position = finalPosition;
    }
}
