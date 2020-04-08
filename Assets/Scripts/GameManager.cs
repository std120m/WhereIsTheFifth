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
    public List<Unit> CatacombsEnemiesDeck;
    public List<CardObject> ShopDeck;
    public List<Warrior> ActiveWarriors;
    public List<Warrior> HandWarriors;
    public bool IsPlayerTurn;

    public Game()
    {
        State = GameState.Basic;

        Enemies = new List<Unit>();
        CatacombsEnemiesDeck = new List<Unit>();
        ShopDeck = new List<CardObject>();
        ActiveWarriors = new List<Warrior>();
        HandWarriors = new List<Warrior>();

        InitHandWarriors();
        InitCatacombsEnemies();
    }

    public void InitFight(List<Unit> enemies)
    {
        State = GameState.Fight;
        IsPlayerTurn = true;
        foreach (Unit enemy in enemies)
        {
            foreach (Warrior warrior in HandWarriors)
            {
                enemy.Attack += warrior.WasAttacked;
                warrior.Attack += enemy.WasAttacked;
            }
        }
    }

    public void ChangeTurn()
    {
        if (IsPlayerTurn)
            IsPlayerTurn = false;
        else
            IsPlayerTurn = true;
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

    public void InitCatacombsEnemies()
    {
        List<Unit> allObjects = new List<Unit>();
        foreach (Unit unit in ObjectManager.CatacombsEnemies.Values)
        {
            allObjects.Add(unit);
        }
        for (int i = 0; i < 1; i++)
        {
            int index = Random.Range(0, allObjects.Count);
            CatacombsEnemiesDeck.Add(allObjects[index]);
            allObjects.RemoveAt(index);

            Debug.Log($"Card {CatacombsEnemiesDeck[i].ToString()} was init");
        }
    }
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public Game Game;
    public GameObject WarriorCardPref, WeaponCardPref, UnitCardPref;
    public Transform SquadField, InventoryField, CatacombsField, ShopField, GameField, ActiveField;
    private List<Unit> currentEnemies = new List<Unit>();
    
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
            warrior.UpdateInfo += cardGO.GetComponent<UnitCardVM>().ShowCard;
            cardGO.GetComponent<WarriorCardVM>().Click += ShowInventory;
            warrior.Death += OnWarriorDeath;
        }
    }

    private void OnWarriorDeath(Unit sender)
    {
        int index = -1;
        for (int i = 0; i < ActiveField.childCount; i++)
        {
            if(ActiveField.GetChild(i).gameObject.GetComponent<WarriorCardVM>().Name.text == sender.Name)
            {
                index = i;
                break;
            }
        }
        if (index != -1)
        {
            Debug.Log($"{sender.ToString()} is dead");
            Destroy(ActiveField.GetChild(index).gameObject);
            Game.ActiveWarriors.Remove(sender as Warrior);
        }
    }

    private void OnUnitDeath(Unit sender)
    {
        int index = -1;
        for (int i = 0; i < GameField.childCount; i++)
        {
            if (GameField.GetChild(i).gameObject.GetComponent<UnitCardVM>().Name.text == sender.Name)
            {
                index = i;
                break;
            }
        }
        if (index != -1)
        {
            Debug.Log($"{sender.ToString()} is dead");
            Destroy(GameField.GetChild(index).gameObject);
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

    public void OnCatacombsDeckClick()
    {
        if (Game.State == GameState.Basic)
        {
            Unit unit = Game.CatacombsEnemiesDeck[Random.Range(0, Game.CatacombsEnemiesDeck.Count)];
            GameObject cardGO = Instantiate(UnitCardPref, GameField, false);
            cardGO.GetComponent<UnitCardVM>().ShowCard(unit);
            unit.UpdateInfo += cardGO.GetComponent<UnitCardVM>().ShowCard;
            currentEnemies.Add(unit);
            unit.Death += OnUnitDeath;
            Game.InitFight(currentEnemies);
            Debug.Log($"Start fight with {unit.ToString()}");
        }
    }

    public void EnemyTurn()
    {
        Game.ChangeTurn();
        if(!Game.IsPlayerTurn)
        {
            foreach (Unit enemy in currentEnemies)
            {
                Warrior warrior = Game.ActiveWarriors[Random.Range(0, Game.ActiveWarriors.Count)];
                enemy.OnAttack(warrior, enemy);
            }

            Game.ChangeTurn();
        }
    }


    void Update()
    {
        
    }
}
