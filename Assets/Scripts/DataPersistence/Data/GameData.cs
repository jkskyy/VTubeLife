using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float hp, hpMax, hunger, hungerMax, thirst, thirstMax, entertainment, entertainmentMax, energy, energyMax, mental, mentalMax, fame, money;
    public int followers, subs, mods, donators, gameover, food, drinks;
    public int hour, minute, day, month, year;

    public GameData()
    {
        this.hp = 100;
        this.hpMax = 100;
        this.hunger = 100;
        this.hungerMax = 100;
        this.thirst = 100;
        this.thirstMax = 100;
        this.entertainment = 100;
        this.entertainmentMax = 100;
        this.energy = 100;
        this.energyMax = 100;
        this.mental = 100;
        this.fame = 0;
        this.money = 500;
        this.followers = 0;
        this.subs = 0;
        this.mods = 0;
        this.donators = 0;
        this.gameover = 0;
        this.food = 0;
        this.drinks = 0;
        this.hour = 0;
        this.minute = 0;
        this.day = 1;
        this.month = 1;
        this.year = 2023;
    }
}
