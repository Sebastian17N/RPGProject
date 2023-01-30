using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    public GameObject[] Characters;
    public Transform spawnPoint;

    void Start()
    {
        Instantiate(Characters[SaveScript.pchar], spawnPoint.position, spawnPoint.rotation);
    } 
}
