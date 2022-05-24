using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : AnimalTwo
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateCube();
    }

    public override void AnimalSound()
    {
        SetSpeed(20.0f);
        displayText.text = "Meow! Cube speed is: "+ Mathf.FloorToInt(m_Speed);
    }

    public override void RotateCube()
    {
        cube.transform.Rotate(Vector3.up,m_Speed*Time.deltaTime);
        
    }
}
