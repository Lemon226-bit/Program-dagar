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
    public float moneyPerInterval = 1f;
    public int moneyLevel = 0;
    public int maxMoneyLevel = 5;
    public float moneyUpgradeAmount = 1f;
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
    public void UpgradeFuel()
    {
        if (money >= level1)
        {
            uitext.enabled = false;
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                money -= level1;
                baseFuel += fuelUpgradeAmount;

            }

        }
        if (money != level1)
        { uitext.enabled = true; }

        if (money >= level2)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                money -= level2;
                baseFuel += fuelUpgradeAmount;

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
                money -= level3;
                baseFuel += fuelUpgradeAmount;

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
                money -= level4;
                baseFuel += fuelUpgradeAmount;

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
                money -= level5;
                baseFuel += fuelUpgradeAmount;

            }
            counter3.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }
    }
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
        { uitext.text = "fattig"; }

        if (money >= level2)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                money -= level2;
                moneyPerInterval += moneyUpgradeAmount;

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
                money -= level3;
                moneyPerInterval += moneyUpgradeAmount;

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
                money -= level4;
                moneyPerInterval += moneyUpgradeAmount;

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
                money -= level5;
                moneyPerInterval += moneyUpgradeAmount;

            }
            counter4.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }
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
        { uitext.text = "fattig"; }

        if (money >= level2)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                money -= level2;
                baseHealth += healthUpgradeAmount;

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
                money -= level3;
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
                money -= level4;
                baseHealth += healthUpgradeAmount;

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
                money -= level5;
                baseHealth += healthUpgradeAmount;

            }
            uitext.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }
    }

}
