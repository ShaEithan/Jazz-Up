using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject musicianPrefab; 
    public GameObject spawnPoint;
    public Transform spawnPointTransform; 
    
    public float spawnInterval;
    float currentTime;

    public bool spawnLeft;

    // Start is called before the first frame update
    void Start()
    {
        spawnLeft = true;
        currentTime = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        while (currentTime >= spawnInterval) {
            spawnEntity();
            spawnLeft = !spawnLeft;
            currentTime -= spawnInterval;
        }
    }

    void spawnEntity(){
        GameObject musicianCopy;

        if (spawnLeft) {
            musicianCopy = Instantiate(musicianPrefab, transform.position, transform.rotation);
        } else {
            musicianCopy = Instantiate(musicianPrefab, transform.position, transform.rotation);
        }
        
        Destroy(musicianCopy, 10f);
    }
}
