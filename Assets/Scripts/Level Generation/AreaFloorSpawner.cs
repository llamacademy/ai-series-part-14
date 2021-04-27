using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaFloorSpawner : MonoBehaviour
{
    [SerializeField]
    private FloorSection[] FloorPrefabs;
    [SerializeField]
    private Vector2Int WorldSize;

    private void Start()
    {
        StartCoroutine(SpawnFloor());
    }

    private IEnumerator SpawnFloor()
    {
        for (int x = -1 * WorldSize.x / 2; x < WorldSize.x / 2; x++)
        {
            for (int y = -1 * WorldSize.y / 2; y < WorldSize.y / 2; y++)
            {
                FloorSection floor = Instantiate(FloorPrefabs[Random.Range(0, FloorPrefabs.Length)]);
                yield return null;
            }

            yield return null;
        }
    }
}
