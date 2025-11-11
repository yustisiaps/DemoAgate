using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContohList : MonoBehaviour
{
     [SerializeField]
    public List<Player> players = new List<Player>();
    void Start()
    {
        players.Add(new Player("Yusti", 1, 100));
        players.Add(new Player("Alya", 5, 150));
        players.Add(new Player("Rian", 3, 120));

        foreach (var p in players)
        {
            Debug.Log("Player: " + p.name + ", Level: " + p.level + ", Health: " + p.health);
        }
        
    }

    void Update()
    {
        
    }
}
