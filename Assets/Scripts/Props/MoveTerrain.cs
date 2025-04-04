using System.Threading;
using UnityEngine;

public class MoveTerrain : MonoBehaviour
{
    //[Header("Parameters")]

    //[Header("References")]

    //[Header("RSE")]

    [Header("RSO")]
    [SerializeField] RSO_TerrainMoveSpeed rsoTerrainMoveSpeed;

    //[Header("SSO")]

    private void Update()
    {
        transform.position += new Vector3(0, 0, rsoTerrainMoveSpeed.Value) * Time.deltaTime;
    }
}