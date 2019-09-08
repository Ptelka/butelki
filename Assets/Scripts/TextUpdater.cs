using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextUpdater : MonoBehaviour
{
    public Sprite[] sprites;
    Queue<Sprite> texts = new Queue<Sprite>();

    void Awake()
    {
        foreach (var v in sprites)
        {
            texts.Enqueue(v);
        }
    }

    public void Trigger()
    {
        while (texts.Count > 0)
        {
            TextOutputWindow.GetInstance().push(texts.Dequeue());
        }
    }
}
