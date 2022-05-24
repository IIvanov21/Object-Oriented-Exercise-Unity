using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Animal : MonoBehaviour
{
    public int numOfLegs;
    public string typeOfAnimal;
    public TMP_Text displayInfo;

    public void AnimalSound()
    {
        displayInfo.text = "No sound!";
    }

    
}
