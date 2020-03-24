using Assets.Scripts.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Assets.Scripts.ViewModel;

public enum GameState
{
    Fight,
    Shop,
    Basic
}

public class Game
{
    public GameState State;
    public List<Unit> Enemies;
    public List<CardObject> CatacombsDeck;
    public List<CardObject> ShopDeck;
    public List<Warrior> ActiveWarriors;
    public List<Warrior> HandWarriors;

    public Game()
    {
        State = GameState.Basic;

        Enemies = new List<Unit>();
        CatacombsDeck = new List<CardObject>();
        ShopDeck = new List<CardObject>();
        ActiveWarriors = new List<Warrior>();
        HandWarriors = new List<Warrior>();

        InitHandWarriors();
    }

    public void InitHandWarriors()
    {
        List<Warrior> allWarriors = new List<Warrior>();
        foreach (Warrior warrior in ObjectManager.Warriors.Values)
        {
            allWarriors.Add(warrior);
        }

        for (int i = 0; i < 2; i++)
        {
            int index = Random.Range(0, allWarriors.Count);
            HandWarriors.Add(allWarriors[index]);
            allWarriors.RemoveAt(index);

            Debug.Log($"Card {HandWarriors[i].ToString()} was init");
        }
    }
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Game Game;
    public GameObject WarriorCardPref, WeaponCardPref;
    public Transform SquadField, InventoryField, CatacombsField, ShopField;
    // Start is called before the first frame update
    void Start()
    {
        Game = new Game();
        Instance = this; 
        InitWarriorsCard();
    }

    private void InitWarriorsCard()
    {
        foreach (Warrior warrior in Game.HandWarriors)
        {
            GameObject cardGO =  Instantiate(WarriorCardPref, SquadField, false);
            cardGO.GetComponent<WarriorCardVM>().ShowCard(warrior);
            cardGO.GetComponent<WarriorCardVM>().Click += ShowInventory;
        }
    }

    public void ShowInventory(Warrior warrior)
    {
        for (int i = 0; i < InventoryField.childCount; i++)
        {
            Destroy(InventoryField.GetChild(i).gameObject);
        }
        if (warrior.Weapon != null)
        {
            GameObject cardGO = Instantiate(WeaponCardPref, InventoryField, false);
            cardGO.GetComponent<WeaponCardVM>().ShowCard(warrior.Weapon);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
