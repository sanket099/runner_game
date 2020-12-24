using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawn ground;

    public GameObject ObstaclePrefab;
    // Start is called before the first frame update
    void Start()
    {
        ground = GameObject.FindObjectOfType<GroundSpawn>();
        SpawnObs();
        
    }

    private void OnTriggerExit(Collider collider){
        ground.SpawnTile();
        Destroy(gameObject,2f);
        ground.SpawnTile();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObs(){
        int obsSpawnInx = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obsSpawnInx).transform;

        Instantiate(ObstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
    }
}
