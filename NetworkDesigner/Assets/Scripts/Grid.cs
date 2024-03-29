using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField]
    private float size = FindObjectOfType<SpawnTerreno>().TamanoStandar();

    public Vector3 GetNearestPointOnGrid(Vector3 position)
    {
        position -= transform.position;

        int xCount = Mathf.RoundToInt(position.x / size);
        int yCount = 1;
        int zCount = Mathf.RoundToInt(position.z / size);

        Vector3 result = new Vector3(
            (float)xCount * size,
            (float)FindObjectOfType<SpawnTerreno>().enviarLargo(),
            (float)zCount * size);

        result += transform.position;

        return result;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        for(float x = 0; x < 40; x += size)
        {
            for (float z = 0; z < 40; z += size)
            {
                var point = GetNearestPointOnGrid(new Vector3(x, 1f, z));
                Gizmos.DrawSphere(point, 0.1f);
            }
        }
    }
}
