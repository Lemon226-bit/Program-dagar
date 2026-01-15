using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float money;

    public TextMeshProUGUI fattig;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI fuel;
    public TextMeshProUGUI Money;
    public TextMeshProUGUI Health;
    int level1 = 5;
    int level2 = 10;
    int level3 = 15;
    int level4 = 20;
    int level5 = 25;
    //Playermovement
    public float baseSpeed = 3f;
    public int speedLevel = 0;
    public int maxSpeedLevel = 5;
    public float speedUpgradeAmount = 3f;
    //Fuel
    public float baseFuel = 20f;
    public int fuelLevel = 0;
    public int maxFuelLevel = 5;
    public float fuelUpgradeAmount = 20f;
    //Money

    //Health
    public float baseHealth = 3f;
    public int healthLevel = 0;
    public int maxHealthLevel = 5;
    public float healthUpgradeAmount = 1f;


    public void Update()
    {
        money = Moneyschript.original.money;
    }
    public void UpgradeSpeed()
    {

        if (speedLevel < maxSpeedLevel)
        {

            speedLevel++;
            money -= level1;
            baseSpeed += speedUpgradeAmount;



        }
        if (money != level1)
        { fattig.text = "fattig"; }
        if (money >= level2)
        {
            speedLevel++;
            baseSpeed += speedUpgradeAmount;
            money -= level2;
            speed.text = "2/5";
        }
        if (money != level2)
        { fattig.text = "fattig"; }

        if (money >= level3)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;
                money -= level3;
            }
            speed.text = "3/5";
        }
        if (money != level3)
        { fattig.text = "fattig"; }

        if (money >= level4)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;
                money -= level4;
            }
            speed.text = "4/5";
        }
        if (money != level4)
        { fattig.text = "fattig"; }

        if (money >= level5)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;
                money -= level5;
            }
            speed.text = "5/5";
        }
        if (money != level5)
        { fattig.text = "fattig"; }

    }
    public void UpgradeFuel()
    {
        if (money >= level1)
        {
            fattig.enabled = false;
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                money -= level1;
                baseFuel += fuelUpgradeAmount;

            }

        }
        if (money != level1)
        { fattig.enabled = true; }

        if (money >= level2)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                money -= level2;
                baseFuel += fuelUpgradeAmount;

            }
            fuel.text = "2/5";
        }
        if (money != level2)
        { fattig.text = "fattig"; }

        if (money == level3)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                money -= level3;
                baseFuel += fuelUpgradeAmount;

            }
            fuel.text = "3/5";
        }
        if (money != level3)
        { fattig.text = "fattig"; }

        if (money == level4)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                money -= level4;
                baseFuel += fuelUpgradeAmount;

            }
            fuel.text = "4/5";
        }
        if (money != level4)
        { fattig.text = "fattig"; }

        if (money >= level5)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                money -= level5;
                baseFuel += fuelUpgradeAmount;

            }
            fuel.text = "5/5";
        }
        if (money != level5)
        { fattig.text = "fattig"; }
    }

    public float moneyPerInterval = 0.25f;
    public int moneyLevel = 0;
    public int maxMoneyLevel = 5;
    public float moneyUpgradeAmount = 1f;
    public void UpgradeMoney()
    {
        print(money);
        print(level1);
        if (money >= level1)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                money -= level1;
                moneyPerInterval += moneyUpgradeAmount;

            }

        }
        if (money != level1)
        { fattig.text = "fattig"; }

        if (money >= level2)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                money -= level2;
                moneyPerInterval += moneyUpgradeAmount;

            }
            Money.text = "2/5";
        }
        if (money != level2)
        { fattig.text = "fattig"; }

        if (money >= level3)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                money -= level3;
                moneyPerInterval += moneyUpgradeAmount;

            }
            Money.text = "3/5";
        }
        if (money != level3)
        { fattig.text = "fattig"; }

        if (money >= level4)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                money -= level4;
                moneyPerInterval += moneyUpgradeAmount;

            }
            Money.text = "4/5";
        }
        if (money != level4)
        { fattig.text = "fattig"; }

        if (money >= level5)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                money -= level5;
                moneyPerInterval += moneyUpgradeAmount;

            }
            Money.text = "5/5";
        }
        if (money != level5)
        { fattig.text = "fattig"; }
    }
    public void UpgradeHealth()
    {
        if (money >= level1)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                money -= level1;
                baseHealth += healthUpgradeAmount;

            }

        }
        if (money != level1)
        { fattig.text = "fattig"; }

        if (money >= level2)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                money -= level2;
                baseHealth += healthUpgradeAmount;

            }
            Health.text = "2/5";
        }
        if (money != level2)
        { fattig.text = "fattig"; }

        if (money >= level3)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                money -= level3;
                baseHealth += healthUpgradeAmount;
                money -= level3;
            }
            Health.text = "3/5";
        }
        if (money != level3)
        { fattig.text = "fattig"; }

        if (money >= level4)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                money -= level4;
                baseHealth += healthUpgradeAmount;

            }
            Health.text = "4/5";
        }
        else if (money != level4)
        { fattig.text = "fattig"; }

        if (money >= level5)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                money -= level5;
                baseHealth += healthUpgradeAmount;

            }
            Health.text = "5/5";
        }
        if (money != level5)
        { fattig.text = "fattig"; }
    }

}
