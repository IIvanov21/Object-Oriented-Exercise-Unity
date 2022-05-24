using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor;

public abstract class AnimalTwo : MonoBehaviour
{
    [SerializeField]protected TMP_Text displayText;

    [SerializeField] protected GameObject cube; 

    public float m_Speed { get; private set; }

    protected void SetSpeed(float speed)
    {
        m_Speed = speed;
    }
    // Start is called before the first frame update
    public abstract void AnimalSound();
    public abstract void RotateCube();
}
