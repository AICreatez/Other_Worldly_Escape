using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementFollow : MonoBehaviour
{
    NavMeshAgent Enemy;

    GameObject Player;
    
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<NavMeshAgent>();
        Player=GameObject.FindWithTag("Player"); //enemy fetching the player using the tag
    }

    // Update is called once per frame
    void Update()
    {
        Enemy.SetDestination(Player.transform.position); // setting the goal for the enemy to chase aka player
    }
}
