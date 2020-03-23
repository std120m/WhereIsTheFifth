using Assets.Scripts.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum GameState
{
    Fight,
    Shop,
    Basic
}

public class Game
{
    public GameState State;
    public List<CardObject> Enemies;
    public List<CardObject> CatacombsDeck;
    public List<CardObject> ShopDeck;
    public List<Unit> ActiveWarriors;
    public List<Unit> HandWarriors;

    public Game()
    {
        State = GameState.Basic;

        Enemies = new List<CardObject>();
        CatacombsDeck = new List<CardObject>();
        ShopDeck = new List<CardObject>();
        ActiveWarriors = new List<Unit>();
        HandWarriors = new List<Unit>();
    }
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Game Game;
    // Start is called before the first frame update
    void Start()
    {
        Game = new Game();
        Instance = this;
        Game.HandWarriors.Add(CardManager.WarriorCards[0].CardObject as Unit);
        Game.HandWarriors.Add(CardManager.WarriorCards[1].CardObject as Unit);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
