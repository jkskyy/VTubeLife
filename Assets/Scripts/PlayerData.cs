using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour, IDataPersistence
{
    public float hp, hpMax, hunger, hungerMax, thirst, thirstMax, entertainment, entertainmentMax, energy, energyMax, mental, mentalMax, fame, money;
    public int followers, subs, mods, donators, gameover, food, drinks;
    public GameObject hpSlider, hungerSlider, thirstSlider, entertainmentSlider, energySlider, mentalSlider;
    public Text hpText, hungerText, thirstText, entertainmentText, energyText, mentalText, fameText, moneyText;
    int min = 0, max = 100;
    public timedate timedate;

    public void LoadData(GameData gameData)
    {
        this.hp = gameData.hp;
        this.hpMax = gameData.hpMax;
        this.hunger = gameData.hunger;
        this.hungerMax = gameData.hungerMax;
        this.thirst = gameData.thirst;
        this.thirstMax = gameData.thirstMax;
        this.entertainment = gameData.entertainment;
        this.entertainmentMax = gameData.entertainmentMax;
        this.energy = gameData.energy;
        this.energyMax = gameData.energyMax;
        this.mental = gameData.mental;
        this.mentalMax = gameData.mentalMax;
        this.fame = gameData.fame;
        this.money = gameData.money;
        this.followers = gameData.followers;
        this.subs = gameData.subs;
        this.mods = gameData.mods;
        this.donators = gameData.donators;
        this.gameover = gameData.gameover;
        this.food = gameData.food;
        this.drinks = gameData.drinks;
    }

    public void SaveData(GameData gameData)
    {
        gameData.hp = this.hp;
        gameData.hpMax = this.hpMax;
        gameData.hunger = this.hunger;
        gameData.hungerMax = this.hungerMax;
        gameData.thirst = this.thirst;
        gameData.thirstMax = this.thirstMax;
        gameData.entertainment = this.entertainment;
        gameData.entertainmentMax = this.entertainmentMax;
        gameData.energy = this.energy;
        gameData.energyMax = this.energyMax;
        gameData.mental = this.mental;
        gameData.mentalMax = this.mentalMax;
        gameData.fame = this.fame;
        gameData.money = this.money;
        gameData.followers = this.followers;
        gameData.subs = this.subs;
        gameData.mods = this.mods;
        gameData.donators = this.donators;
        gameData.gameover = this.gameover;
        gameData.food = this.food;
        gameData.drinks = this.drinks;
    }
    void Start()
    {
        hpSlider.transform.localScale = new Vector3(hp / 100, 1, 1);
        hungerSlider.transform.localScale = new Vector3(hunger / 100, 1, 1);
        thirstSlider.transform.localScale = new Vector3(thirst / 100, 1, 1);
        entertainmentSlider.transform.localScale = new Vector3(entertainment / 100, 1, 1);
        energySlider.transform.localScale = new Vector3(energy / 100, 1, 1);
        mentalSlider.transform.localScale = new Vector3(mental / 100, 1, 1);
        hpText.text = Mathf.FloorToInt(hp).ToString();
        hungerText.text = Mathf.FloorToInt(hunger).ToString();
        thirstText.text = Mathf.FloorToInt(thirst).ToString();
        entertainmentText.text = Mathf.FloorToInt(entertainment).ToString();
        energyText.text = Mathf.FloorToInt(energy).ToString();
        mentalText.text = Mathf.FloorToInt(mental).ToString();
        fameText.text = Mathf.FloorToInt(fame).ToString();
        moneyText.text = Mathf.FloorToInt(money).ToString();
    }
    void Update()
    {
        hp = Mathf.Clamp(hp, min, max);
        hunger = Mathf.Clamp(hunger, min, max);
        thirst = Mathf.Clamp(thirst, min, max);
        entertainment = Mathf.Clamp(entertainment, min, max);
        energy = Mathf.Clamp(energy, min, max);
        mental = Mathf.Clamp(mental, min, max);
    }

    public void Sleep()
    {
        hp = Mathf.Clamp(hp + 20, min, max);
        energy = Mathf.Clamp(energy + 50, min, max);
        mental = Mathf.Clamp(mental + 30, min, max);
        entertainment = Mathf.Clamp(entertainment - 20, min, max);
        hunger = Mathf.Clamp(hunger - 30, min, max);
        thirst = Mathf.Clamp(thirst - 30, min, max);
        hpSlider.transform.localScale = new Vector3(Mathf.Clamp(hp / 100, 0, 1), 1, 1);
        hpText.text = Mathf.FloorToInt(hp).ToString();
        energySlider.transform.localScale = new Vector3(Mathf.Clamp(energy / 100, 0, 1), 1, 1);
        energyText.text = Mathf.FloorToInt(energy).ToString();
        mentalSlider.transform.localScale = new Vector3(Mathf.Clamp(mental / 100, 0, 1), 1, 1);
        mentalText.text = Mathf.FloorToInt(mental).ToString();
        entertainmentSlider.transform.localScale = new Vector3(Mathf.Clamp(entertainment / 100, 0, 1), 1, 1);
        entertainmentText.text = Mathf.FloorToInt(entertainment).ToString();
        hungerSlider.transform.localScale = new Vector3(Mathf.Clamp(hunger / 100, 0, 1), 1, 1);
        hungerText.text = Mathf.FloorToInt(hunger).ToString();
        thirstSlider.transform.localScale = new Vector3(Mathf.Clamp(thirst / 100, 0, 1), 1, 1);
        thirstText.text = Mathf.FloorToInt(thirst).ToString();
        timedate.hour += 8;
        timedate.CheckTime();
    }
    public void Eat()
    {
        hp = Mathf.Clamp(hp + 5, min, max);
        energy = Mathf.Clamp(energy + 20, min, max);
        mental = Mathf.Clamp(mental + 10, min, max);
        entertainment = Mathf.Clamp(entertainment + 10, min, max);
        hunger = Mathf.Clamp(hunger + 30, min, max);
        hpSlider.transform.localScale = new Vector3(Mathf.Clamp(hp / 100, 0, 1), 1, 1);
        hpText.text = Mathf.FloorToInt(hp).ToString();
        energySlider.transform.localScale = new Vector3(Mathf.Clamp(energy / 100, 0, 1), 1, 1);
        energyText.text = Mathf.FloorToInt(energy).ToString();
        mentalSlider.transform.localScale = new Vector3(Mathf.Clamp(mental / 100, 0, 1), 1, 1);
        mentalText.text = Mathf.FloorToInt(mental).ToString();
        entertainmentSlider.transform.localScale = new Vector3(Mathf.Clamp(entertainment / 100, 0, 1), 1, 1);
        entertainmentText.text = Mathf.FloorToInt(entertainment).ToString();
        hungerSlider.transform.localScale = new Vector3(Mathf.Clamp(hunger / 100, 0, 1), 1, 1);
        hungerText.text = Mathf.FloorToInt(hunger).ToString();
        timedate.hour += 1;
        timedate.CheckTime();
    }
    public void Drink()
    {
        hp = Mathf.Clamp(hp + 5, min, max);
        energy = Mathf.Clamp(energy + 20, min, max);
        mental = Mathf.Clamp(mental + 10, min, max);
        entertainment = Mathf.Clamp(entertainment + 10, min, max);
        thirst = Mathf.Clamp(thirst + 30, min, max);
        hpSlider.transform.localScale = new Vector3(Mathf.Clamp(hp / 100, 0, 1), 1, 1);
        hpText.text = Mathf.FloorToInt(hp).ToString();
        energySlider.transform.localScale = new Vector3(Mathf.Clamp(energy / 100, 0, 1), 1, 1);
        energyText.text = Mathf.FloorToInt(energy).ToString();
        mentalSlider.transform.localScale = new Vector3(Mathf.Clamp(mental / 100, 0, 1), 1, 1);
        mentalText.text = Mathf.FloorToInt(mental).ToString();
        entertainmentSlider.transform.localScale = new Vector3(Mathf.Clamp(entertainment / 100, 0, 1), 1, 1);
        entertainmentText.text = Mathf.FloorToInt(entertainment).ToString();
        thirstSlider.transform.localScale = new Vector3(Mathf.Clamp(thirst / 100, 0, 1), 1, 1);
        thirstText.text = Mathf.FloorToInt(thirst).ToString();
        timedate.hour += 1;
        timedate.CheckTime();
    }

    public Dictionary<string, int> StatsData()
    {
        var dictionary = new Dictionary<string, int>
        {
            {"hp", Mathf.FloorToInt(hp)},
            {"hunger", Mathf.FloorToInt(hunger)},
            {"thirst", Mathf.FloorToInt(thirst)},
            {"entertainment", Mathf.FloorToInt(entertainment)},
            {"energy", Mathf.FloorToInt(energy)},
            {"mental", Mathf.FloorToInt(mental)}
        };
        return dictionary;
    }
}
