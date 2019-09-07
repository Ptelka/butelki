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
    private bool done = false;
    public void Stop()
    {
    }

    public void Start()
    {
        if (done)
        {
            return;
        }
        foreach (var wers in refren)
        {
            TextOutputWindow.GetInstance().push(wers);
        }

        done = true;
    }
    
    // Update is called once per frame
    void Update()
    {

    }
}
