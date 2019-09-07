using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOutputWindow: MonoBehaviour
{
    private static Queue<Sprite> sprites = new Queue<Sprite>();
    
    private Image image;
    
    public static void push(Sprite sprite)
    {
        sprites.Enqueue(sprite);
    }

    void Start()
    {
        image = GetComponent<Image>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (sprites.Count > 0)
        {
            image.sprite = sprites.Dequeue();
        }
    }
}
