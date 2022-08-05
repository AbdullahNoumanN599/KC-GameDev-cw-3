using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour
{
    string heroname = "audi v8 engine";
    string heropower = "running";
    string VillianName = "rondaldo mcdonaldo";
    string villianpower = "walking";
    int HeroPowerLevel = 9;
    int VillianPowerLevel = 9;
    float playerspeed = 0f;

    // Start is called before the first frame update
    void Start()

    {
        if (HeroPowerLevel > VillianPowerLevel)
        {

            print("hand over the phone with the original flappy bird game" + VillianName);

        }
        else
        {
            print("HA" + heroname + "(unused) YOU WILL NEVER BEAT MY HIGHSCORE IN FLAPPY BIRD!");

        }

        playerspeed = setspeed();

            print(playerspeed);
            

   }

    // Update is called once per frame
    void Update()
    {




   
    
    }
     float setspeed()
    {
        float result = 2.5f;  
        return result;
    }
    
}
