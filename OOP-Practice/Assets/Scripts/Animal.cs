using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Animal : MonoBehaviour
{
    public int numOfLegs { get; private set; }
    [SerializeField] private string typeOfAnimal;
    public TMP_Text displayInfo;
    public GameObject sphere;
    public virtual void AnimalSound()
    {
        displayInfo.text = "No sound!";
    }

    public void RotateSphere()
    {
        sphere.transform.Rotate(Vector3.up,20.0f*Time.deltaTime);
    }
}

