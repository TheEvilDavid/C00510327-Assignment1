using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;
using UnityEditor.PackageManager;
public class StarCounter : MonoBehaviour
{
    public static StarCounter instance;
    public TMP_Text counter;
    public int starNum = 0;
    int starMax = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counter.text = starNum.ToString() + " / " + starMax.ToString() + " Stars collected";
        if(starNum == starMax)
        {
            counter.text = "You got all the stars! Awesome work!";
            Finishing.instance.SpawnStars();
        }
    }
    public void AddStar()
    {
        starNum += 1;
    }
    
}
