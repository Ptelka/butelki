using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSelector : Clickable
{
    public GameObject current;
    public GameObject screen;
    
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void OnClick()
    {
        current.GetComponent<Screen>().OnLeave();
        var pos = Camera.main.transform.position;
        pos.x = screen.transform.position.x;
        pos.y = screen.transform.position.y;
        Camera.main.transform.position = pos;
        screen.GetComponent<Screen>().OnEnter();
    }
}
