using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float spawnDelayMin = 1.0f;
    private float spawnDelayCurrent = 1.0f;

    // Update is called once per frame
    void Update()
    {
        spawnDelayCurrent += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (spawnDelayCurrent > spawnDelayMin))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            spawnDelayCurrent = 0;
        }
    }
}
