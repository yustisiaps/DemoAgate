using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    public GameObject _someObject;
    public Transform _someTransform;
    // public List<Player> players = new List<Player>();
    // Player player;
    // int number1 = 19;
    // int number2 = 7;
    // int number3 = 7;


    void Start()
    {
    //     // -----------------------------
    //     // Contoh operasi logika
    //     // -----------------------------
    //     bool result = (number1 == number2) || (number2 == number3);
    //     Debug.Log("result = " + result);

        //     // -----------------------------
        //     // Contoh if-else tiket bioskop
        //     // -----------------------------
        //     int age = 18;
        //     int money = 100000;
        //     int ticketPrice = 100000;

        //     Debug.Log("Age = " + age + ", Money = " + money);

        //     if (age >= 18 && money >= ticketPrice)
        //     {
        //         money -= ticketPrice;
        //         Debug.Log("Tiket berhasil dibeli. Selamat menonton!");
        //         Debug.Log("Sisa uang: " + money);
        //     }
        //     else
        //     {
        //         if (age < 18 && money < ticketPrice)
        //             Debug.Log("Tiket ditolak: umur kurang dari 18 tahun dan uang kurang dari 100000.");
        //         else if (age < 18)
        //             Debug.Log("Tiket ditolak: umur kurang dari 18 tahun.");
        //         else
        //             Debug.Log("Tiket ditolak: uang kurang dari 100000.");
        //     }

        //     // -----------------------------
        //     // Contoh switch-case rank senjata
        //     // -----------------------------
        //     int rank = 4; // 1..5, ubah sesuai kebutuhan
        //     string weaponName;

        //     switch (rank)
        //     {
        //         case 1:
        //             weaponName = "Basic Sword";
        //             break;
        //         case 2:
        //             weaponName = "Electric Bow";
        //             break;
        //         case 3:
        //             weaponName = "Fire Spell";
        //             break;
        //         case 4:
        //             weaponName = "Golden Axe (Epic)";
        //             break;
        //         case 5:
        //             weaponName = "Dragon Blade (Legendary)";
        //             break;
        //         default:
        //             weaponName = "Fists (No rank)";
        //             break;
        //     }

        //     Debug.Log("Rank: " + rank + " -> Weapon: " + weaponName);


        //     // 4Contoh pemanggilan fungsi dengan parameter
        //     int returned = ReturnParameter(3);
        //     Debug.Log("ReturnParameter(3) = " + returned);
        // }

        // // Fungsi sederhana untuk mengembalikan nilai parameter
        // int ReturnParameter(int x)
        // {
        //     return x * 2; // contoh: mengembalikan dua kali lipat 

        // players.Add(new Player("Yusti", 1, 100));
        //     players.Add(new Player("Alya", 5, 150));
        //     players.Add(new Player("Rian", 3, 120));

        //     foreach (var p in players)
        //     {
        //         Debug.Log("Player: " + p.name + ", Level: " + p.level + ", Health: " + p.health);
        //     }
    }
    
    void Update()
    {
        
    }
}
