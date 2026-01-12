using TMPro;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public TextMeshProUGUI uitext;
    public TextMeshProUGUI uitext2;
    public TextMeshProUGUI uitext3;
    public TextMeshProUGUI uitext4;
    public TextMeshProUGUI uitext5;
    public TextMeshProUGUI uitext6;

    int money;
    public void Start()
    {
        money = moneyschript.original.money;
    }
    public int level1 = 5;
    public int level2 = 10;
    public int level3 = 15;
    public int level4 = 20;
    public int level5 = 25;




    //Playermovement
    public float baseSpeed = 3f;
    public int speedLevel = 0;
    public int maxSpeedLevel = 5;
    public float speedUpgradeAmount = 3f;

    public void UpgradeSpeed()
    {


        if (money == level1)

            if (speedLevel < maxSpeedLevel)

            {
                if (speedLevel < maxSpeedLevel)
                {
                    speedLevel++;
                    baseSpeed += speedUpgradeAmount;



                }
                uitext.text = "1/5";
            }
        if (money != level1)
        { uitext.text = "fattig"; }
        if (money == level2)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;



            }
            uitext.text = "2/5";
        }
        if (money != level2)
        { uitext.text = "fattig"; }

        if (money == level3)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;



            }
            uitext.text = "3/5";
        }
        if (money != level3)
        { uitext.text = "fattig"; }

        if (money == level4)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;



            }
            uitext.text = "4/5";
        }
        if (money != level4)
        { uitext.text = "fattig"; }

        if (money == level5)
        {
            if (speedLevel < maxSpeedLevel)
            {
                speedLevel++;
                baseSpeed += speedUpgradeAmount;



            }
            uitext.text = "5/5";
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
        if (money == level1)
        {
            uitext.enabled = false;
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
            }
            uitext.text = "1/5";
        }
        if (money != level1)
        { uitext.enabled = true; }

        if (money == level2)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
            }
            uitext.text = "2/5";
        }
        if (money != level2)
        { uitext.text = "fattig"; }

        if (money == level3)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
            }
            uitext.text = "3/5";
        }
        if (money != level3)
        { uitext.text = "fattig"; }

        if (money == level4)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
            }
            uitext.text = "4/5";
        }
        if (money != level4)
        { uitext.text = "fattig"; }

        if (money == level5)
        {
            if (fuelLevel < maxFuelLevel)
            {
                fuelLevel++;
                baseFuel += fuelUpgradeAmount;
            }
            uitext.text = "5/5";
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
        if (money == level1)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
            }
            uitext.text = "1/5";
        }
        if (money != level1)
        { uitext.text = "fattig"; }

        if (money == level2)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
            }
            uitext.text = "2/5";
        }
        if (money != level2)
        { uitext.text = "fattig"; }

        if (money == level3)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
            }
            uitext.text = "3/5";
        }
        if (money != level3)
        { uitext.text = "fattig"; }

        if (money == level4)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
            }
            uitext.text = "4/5";
        }
        if (money != level4)
        { uitext.text = "fattig"; }

        if (money == level5)
        {
            if (moneyLevel < maxMoneyLevel)
            {
                moneyLevel++;
                moneyPerInterval += moneyUpgradeAmount;
            }
            uitext.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }
    }

    //Health
    public float baseHealth = 5f;
    public int healthLevel = 0;
    public int maxHealthLevel = 5;
    public float healthUpgradeAmount = 1f;

    public void UpgradeHealth()
    {
        if (money == level1)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
            }
            uitext.text = "1/5";
        }
        if (money != level1)
        { uitext.text = "fattig"; }

        if (money == level2)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
            }
            uitext.text = "2/5";
        }
        if (money != level2)
        { uitext.text = "fattig"; }

        if (money == level3)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
            }
            uitext.text = "3/5";
        }
        if (money != level3)
        { uitext.text = "fattig"; }

        if (money == level4)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
            }
            uitext.text = "4/5";
        }
        if (money != level4)
        { uitext.text = "fattig"; }

        if (money == level5)
        {
            if (healthLevel < maxHealthLevel)
            {
                healthLevel++;
                baseHealth += healthUpgradeAmount;
            }
            uitext.text = "5/5";
        }
        if (money != level5)
        { uitext.text = "fattig"; }
    }

}
