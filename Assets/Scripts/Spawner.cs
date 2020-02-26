using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    public ParticleSystem particleLauncher;

    public Text scoreText;
    public float scoreAmount;
    public float pointIncreasedPerWhacing;

    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    int number;
    void Start()
    {
        scoreAmount = 0f;
        pointIncreasedPerWhacing = 100f;

        InvokeRepeating("SpawnMouse", 1.0f, 1.5f);
    }
    private void Update()
    {
        scoreText.text = "Score: " + (int)scoreAmount;
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                BoxCollider bc = hit.collider as BoxCollider;
                if (bc != null)
                {
                    Destroy(bc.gameObject);
                    scoreAmount += pointIncreasedPerWhacing;
                    particleLauncher.Emit(1);
                }
            }
        }
    }
    void SpawnMouse()
    {
        number = Random.Range(1, 5);
        if (number == 1)
        {
            whatToSpawnClone[0] = Instantiate(whatToSpawnPrefab[0], spawnLocations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Destroy(GameObject.FindWithTag("Mouse2"));
            Destroy(GameObject.FindWithTag("Mouse3"));
            Destroy(GameObject.FindWithTag("Mouse4"));
        }
        if (number == 2)
        {
            whatToSpawnClone[1] = Instantiate(whatToSpawnPrefab[1], spawnLocations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Destroy(GameObject.FindWithTag("Mouse1"));
            Destroy(GameObject.FindWithTag("Mouse2"));
            Destroy(GameObject.FindWithTag("Mouse4"));
        }
        if (number == 3)
        {
            whatToSpawnClone[2] = Instantiate(whatToSpawnPrefab[2], spawnLocations[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Destroy(GameObject.FindWithTag("Mouse1"));
            Destroy(GameObject.FindWithTag("Mouse3"));
            Destroy(GameObject.FindWithTag("Mouse4"));
        }
        if (number == 4)
        {
            whatToSpawnClone[3] = Instantiate(whatToSpawnPrefab[3], spawnLocations[3].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
            Destroy(GameObject.FindWithTag("Mouse1"));
            Destroy(GameObject.FindWithTag("Mouse2"));
            Destroy(GameObject.FindWithTag("Mouse3"));
        }
    }
}
