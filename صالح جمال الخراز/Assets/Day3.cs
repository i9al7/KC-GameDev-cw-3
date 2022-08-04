using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day3 : MonoBehaviour
{

    //hero
    string heroName = "9al7";
    int heroPower = 100;
    //villain
    string villainName = "n9our";
    int villairPower = 95;
    //
    float playerSpeed = 3.5f;

    // Start is called before the first frame update
    void Start()
    {
        if (heroPower == villairPower)
        {
            print("They have the same powers");
        }
        else if (heroPower < villairPower)
        {
            print(villainName + " stronger");
        }
        else if (heroPower > villairPower)
        {
            print(heroName + " stronger");
        }
        SetSpeed();
        CompareSpeed();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SetSpeed(float newSpeed = 2.5f)
    {
        print("old speed " + playerSpeed);
        playerSpeed = newSpeed;
        print("new speed " + playerSpeed);
    }
    void CompareSpeed()
    {
        float playerSpeed = 3.5f;
        float newSpeed = 2.5f;
        if (playerSpeed == newSpeed)
        {
            print("equal in speed");
        }
        else if (playerSpeed < newSpeed)
        {
            print("new speed is faster");
        }
        else if (playerSpeed > newSpeed)
        {
            print("Old speed is faster");
        }

    }
}