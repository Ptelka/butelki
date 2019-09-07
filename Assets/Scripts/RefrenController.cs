using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefrenController : MonoBehaviour
{
    public Sprite[] refren;
    public float[] times;
    private int iter;
    private float timer;
    private bool isstopped = false;
    public void Stop()
    {
        isstopped = true;
    }

    public void Start()
    {
        isstopped = false;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (isstopped)
        {
            return;
        }
        
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            var current = iter++ % refren.Length;
            TextOutputWindow.push(refren[current]);
            timer = times[current];
        }
    }
}
