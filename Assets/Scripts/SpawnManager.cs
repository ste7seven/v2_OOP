using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnManager : MonoBehaviour
{
    public GameObject autoPrefab; // Das Auto-Prefab, das gespawnt wird
    public Transform[] spawnPoints; // Array mit den Positionen, an denen Autos gespawnt werden
    public float spawnIntervalMin = 0.5f; // Zeitintervall zwischen den Spawns
    public float spawnIntervalMax = 3f; // Zeitintervall zwischen den Spawns

    private void Start()
    {
        // Autos in regelm‰ﬂigen Abst‰nden spawnen
        InvokeRepeating("SpawnAuto", 0f, Random.Range(spawnIntervalMin, spawnIntervalMax));
    }

    void SpawnAuto()
    {
        // W‰hle eine zuf‰llige Spawnposition aus
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(autoPrefab, spawnPoints[randomIndex].position, autoPrefab.transform.rotation);
    }
}
