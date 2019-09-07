using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public void OnEnter()
    {
        gameObject.SetActive(true);

        var refren = GetComponent<RefrenController>();
        if (refren)
        {
            refren.Start();
        }
    }
    
    public void OnLeave()
    {
        gameObject.SetActive(false);
        
        var refren = GetComponent<RefrenController>();
        if (refren)
        {
            refren.Stop();
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
