using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenSelector : Clickable
{
    public TextUpdater updater;
    GameObject current;
    public GameObject screen;
    private SpriteRenderer renderer;
    
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
        current = transform.parent.gameObject;
        renderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        renderer.enabled = !TextOutputWindow.GetInstance().IsOpened();
    }

    override public void OnClick()
    {
        current.GetComponent<Screen>().OnLeave();
        var pos = Camera.main.transform.position;
        pos.x = screen.transform.position.x;
        pos.y = screen.transform.position.y;
        Camera.main.transform.position = pos;
        screen.GetComponent<Screen>().OnEnter();
        
        Debug.Log("Setting cam pos to " + pos + " obj: " + screen);

        if (updater)
        {
            updater.Trigger();
        }
    }
}
