using UnityEngine;
using UnityEngine.Rendering;

public class PlayerStats : MonoBehaviour
{
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
        }
    }

    //Fuel
    public float baseFuel = 20f;
    public int fuelLevel = 0;
    public int maxFuelLevel = 5;
    public float fuelUpgradeAmount = 20f;

    public void UpgradeFuel()
    {
        if (fuelLevel < maxFuelLevel)
        {
            fuelLevel++;
            baseFuel += fuelUpgradeAmount;
        }

    }

    //Money
    public float moneyPerInterval = 1f;
    public int moneyLevel = 0;
    public int maxMoneyLevel = 5;
    public float moneyUpgradeAmount = 1f;

    public void UpgradeMoney()
    {
        if (moneyLevel < maxMoneyLevel)
        {
            moneyLevel++;
            moneyPerInterval += moneyUpgradeAmount;
        }
    }

    //Health
    public float baseHealth = 5f;
    public int healthLevel = 0;
    public int maxHealthLevel = 5;
    public float healthUpgradeAmount = 1f;

    public void UpgradeHealth()
    {
        if (healthLevel < maxHealthLevel)
        {
            healthLevel++;
            baseHealth += healthUpgradeAmount;
        }

    }
    
}
