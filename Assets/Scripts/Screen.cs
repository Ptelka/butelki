using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public TextUpdater updater;
    public Halinka halinka;
    
    public void OnEnter()
    {
        gameObject.SetActive(true);
        if (updater)
        {
            updater.Trigger();
        }
        
        if (halinka)
        {
            halinka.OnScreenExit();
        }
    }
    
    public void OnLeave()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
