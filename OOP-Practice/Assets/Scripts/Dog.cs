using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    public override void AnimalSound()
    {
        base.AnimalSound();
       displayInfo.text = "Bark!";
    }

    void Update()
    {
        RotateSphere();
    }
}
