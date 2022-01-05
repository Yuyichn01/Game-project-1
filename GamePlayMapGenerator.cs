using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayMapGenerator : MonoBehaviour
{
    public float PlayerSpawnDistance;
    [SerializeField] private Transform StartPrefab;
    [SerializeField] private List<Transform> levelPartList;
    [SerializeField] private Transform player;
    private Vector3 lastEndPosition;
    
    public void Awake()
    {
        lastEndPosition = StartPrefab.Find("EndPosition").position;

        int StartingSpawnLevelParts = 5;

        for (int i = 0; i < StartingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Update()
    {
        if (Vector3.Distance(player.position, lastEndPosition) < PlayerSpawnDistance)
        {
            SpawnLevelPart();
        }
    }
    // Start is called before the first frame update

    public void SpawnLevelPart()
    {
        Transform chosenLevelPart = levelPartList[Random.Range(0, levelPartList.Count)];
        Transform lastLevelPartTransform = SpawnLevelPart(chosenLevelPart, lastEndPosition);
        lastEndPosition = lastLevelPartTransform.Find("EndPosition").position;
    }

    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }

}
