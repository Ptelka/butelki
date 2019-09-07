using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Screen : MonoBehaviour
{
    public void OnEnter()
    {
        var refren = GetComponent<RefrenController>();

        if (refren)
        {
            refren.gameObject.SetActive(true);
        }
    }
    
    public void OnLeave()
    {
        var refren = GetComponent<RefrenController>();

        if (refren)
        {
            refren.gameObject.SetActive(false);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
