using UnityEngine;

[System.Serializable]

public class Player
{
    public string name;
    public int level;
    public int health;

    public Player(string name, int level, int health)
    {
        // name = "Player1";
        // level = 1;
        // health = 100;

        name = name;
        level = level;
        health = health;
    }
}
