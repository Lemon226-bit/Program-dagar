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








    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
