using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUpdater : Clickable
{
    public Queue<Sprite> texts = new Queue<Sprite>();
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
    }

    public override void OnClick()
    {
        TextOutputWindow.GetInstance().push(texts.Dequeue());
    }
}
