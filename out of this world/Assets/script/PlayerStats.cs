using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float money;

    public TextMeshProUGUI uitext;
    public TextMeshProUGUI counter2;
    public TextMeshProUGUI counter3;
    public TextMeshProUGUI counter4;
    public TextMeshProUGUI counter5;
    public TextMeshProUGUI counter1;
    int level1 = 5;
    int level2 = 10;
    int level3 = 15;
    int level4 = 20;
    int level5 = 25;


    public void Update()
    {

        money = moneyschript.original.money;

    }
    //Playermovement
    public float baseSpeed = 3f;
    public int speedLevel = 0;
    public int maxSpeedLevel = 5;
    public float speedUpgradeAmount = 3f;

    public void UpgradeSpeed()
    {

        if (speedLevel < maxSpeedLevel)
        {

            speedLevel++;
            baseSpeed += speedUpgradeAmount;
            money -= level1;


        }
        if (money != level1)
        { uitext.text = "fattig"; }
        if (money >= level2)
        {
            speedLevel++;
            baseSpeed += speedUpgradeAmount;
            money -= level2;
            counter1.text = "2/5";
        }
        if (money != level2)
        { uitext.text = "fattig"; }

        if (money >= level3)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;
                money -= level3;
            }
            counter1.text = "3/5";
        }
        if (money != level3)
        { uitext.text = "fattig"; }

        if (money >= level4)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;
                money -= level4;
            }
            counter2.text = "4/5";
        }
        if (money != level4)
        { uitext.text = "fattig"; }

        if (money >= level5)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;
                money -= level5;
            }
            counter2.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }

    }

    //Fuel
    public float baseFuel = 20f;
    public int fuelLevel = 0;
    public int maxFuelLevel = 5;
    public float fuelUpgradeAmount = 20f;

    public void UpgradeFuel()
    {
        if (money >= level1)
        {
            uitext.enabled = false;
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
                money -= level1;
            }

        }
        if (money != level1)
        { uitext.enabled = true; }

        if (money >= level2)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
                money -= level2;
            }
            counter3.text = "2/5";
        }
        if (money != level2)
        { uitext.text = "fattig"; }

        if (money == level3)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
                money -= level3;
            }
            counter3.text = "3/5";
        }
        if (money != level3)
        { uitext.text = "fattig"; }

        if (money == level4)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
                money -= level4;
            }
            counter3.text = "4/5";
        }
        if (money != level4)
        { uitext.text = "fattig"; }

        if (money >= level5)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
                money -= level5;
            }
            counter3.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }
    }


    //Money
    public float moneyPerInterval = 1f;
    public int moneyLevel = 0;
    public int maxMoneyLevel = 5;
    public float moneyUpgradeAmount = 1f;

    public void UpgradeMoney()
    {
        if (money >= level1)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
                money -= level1;
            }

        }
        if (money != level1)
        { uitext.text = "fattig"; }

        if (money >= level2)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
                money -= level2;
            }
            counter4.text = "2/5";
        }
        if (money != level2)
        { uitext.text = "fattig"; }

        if (money >= level3)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
                money -= level3;
            }
            counter4.text = "3/5";
        }
        if (money != level3)
        { uitext.text = "fattig"; }

        if (money >= level4)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
                money -= level4;
            }
            counter4.text = "4/5";
        }
        if (money != level4)
        { uitext.text = "fattig"; }

        if (money >= level5)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
                money -= level5;
            }
            counter4.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }
    }

    //Health
    public float baseHealth = 3f;
    public int healthLevel = 0;
    public int maxHealthLevel = 5;
    public float healthUpgradeAmount = 1f;

    public void UpgradeHealth()
    {
        if (money >= level1)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
                money -= level1;
            }

        }
        if (money != level1)
        { uitext.text = "fattig"; }

        if (money >= level2)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
                money -= level2;
            }
            counter2.text = "2/5";
        }
        if (money != level2)
        { uitext.text = "fattig"; }

        if (money >= level3)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
                money -= level3;
            }
            counter3.text = "3/5";
        }
        if (money != level3)
        { uitext.text = "fattig"; }

        if (money >= level4)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
                money -= level4;
            }
            uitext.text = "4/5";
        }
        else if (money != level4)
        { uitext.text = "fattig"; }

        if (money >= level5)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
                money -= level5;
            }
            uitext.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }
    }

}
