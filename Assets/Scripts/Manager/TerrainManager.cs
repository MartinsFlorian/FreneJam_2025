using System.Collections;
using UnityEngine;

public class TerrainManager : MonoBehaviour
{
    [Header("Parameters")]
    [SerializeField] float delayIncreaseMoveSpeed;
    [SerializeField] float valueMoveSpeed;
    float initialMoveSpeed = 0f;

    [Header("References")]
    [SerializeField] Transform terrainSpawnPoint;
    [SerializeField] GameObject[] terrain;

    [Header("RSE")]
    [SerializeField] RSE_SpawnNewTerrain rseSpawnNewTerrain;

    [Header("RSO")]
    [SerializeField] RSO_TerrainMoveSpeed rsoTerrainMoveSpeed;

    //[Header("SSO")]
    private void OnEnable()
    {
        rseSpawnNewTerrain.action += SpawnTerrain;
    }
    private void OnDisable()
    {
        rseSpawnNewTerrain.action -= SpawnTerrain;
    }
    private void OnDestroy()
    {
        rsoTerrainMoveSpeed.Value = initialMoveSpeed;
    }
    private void Start()
    {
        initialMoveSpeed = rsoTerrainMoveSpeed.Value;
        StartCoroutine(IncreaseTerrainMoveSpeed(delayIncreaseMoveSpeed));
    }
    private void SpawnTerrain()
    {
        int rnd = Random.Range(0,terrain.Length);
        Instantiate(terrain[rnd], terrainSpawnPoint.position, Quaternion.identity);
    }
    IEnumerator IncreaseTerrainMoveSpeed(float speed)
    {
        yield return new WaitForSeconds(speed);
        rsoTerrainMoveSpeed.Value -= valueMoveSpeed;
        StartCoroutine(IncreaseTerrainMoveSpeed(speed));
    }
}