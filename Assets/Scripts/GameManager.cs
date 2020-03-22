using Assets.Scripts.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game
{
    public List<CardObject> Enemies;
    public List<Unit> ActiveWarriors;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Game Game;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
