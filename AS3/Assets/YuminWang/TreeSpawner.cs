using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour
{
    public GameObject treePrefab;
    public int treeCount = 500;
    public float areaSize = 100f;

    public LayerMask groundLayer;

    void Start()
    {
        for (int i = 0; i < treeCount; i++)
        {
            Vector3 randomPosition = new Vector3(
                Random.Range(-areaSize / 2f, areaSize / 2f),
                100f,
                Random.Range(-areaSize / 2f, areaSize / 2f)
            );

            if (Physics.Raycast(randomPosition, Vector3.down, out RaycastHit hit, 200f, groundLayer))
            {
                Vector3 spawnPos = hit.point;
                Quaternion rotation = Quaternion.Euler(0f, Random.Range(0f, 360f), 0f);
                Instantiate(treePrefab, spawnPos, rotation, this.transform);
            }
        }
    }
}
