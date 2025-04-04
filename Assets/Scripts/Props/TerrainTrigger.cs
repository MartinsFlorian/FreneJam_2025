using UnityEngine;

public class TerrainTrigger : MonoBehaviour
{
    //[Header("Parameters")]

    //[Header("References")]

    [Header("RSE")]
    [SerializeField] RSE_SpawnNewTerrain rseSpawnNewTerrain;

    //[Header("RSO")]

    //[Header("SSO")]

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            rseSpawnNewTerrain.RaiseEvent();
        }
    }
}