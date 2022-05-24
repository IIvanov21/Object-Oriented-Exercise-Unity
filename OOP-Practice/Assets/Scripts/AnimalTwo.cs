using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public abstract class AnimalTwo : MonoBehaviour
{
    [SerializeField]protected TMP_Text displayText;

    [SerializeField] protected GameObject cube; 
    // Start is called before the first frame update
    public abstract void AnimalSound();
    public abstract void RotateCube();
}
