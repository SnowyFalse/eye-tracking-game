using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinManager : MonoBehaviour
{

   
    
    [SerializeField] private Text counterText;
    [SerializeField] private GameObject firstHeart;
    [SerializeField] private GameObject secondHeart;
    [SerializeField] private GameObject thirdHeart;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        counterText.text = VirtualInputManager.Instance.winCounter.ToString();
        if (VirtualInputManager.Instance.loseCounter >= 1)
        {
            firstHeart.SetActive(false);
        }
        if (VirtualInputManager.Instance.loseCounter >= 2)
        {
            secondHeart.SetActive(false);
        }
        if (VirtualInputManager.Instance.loseCounter >= 3)
        {
            thirdHeart.SetActive(false);
            Debug.Log("you lost");

        }
    }
}

