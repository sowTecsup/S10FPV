using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;

    public float distance;
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(player.transform.position, enemy.transform.position);
    }
}
