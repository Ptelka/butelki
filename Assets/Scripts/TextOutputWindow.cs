using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;
using UnityEngine.UI;

public class TextOutputWindow: MonoBehaviour
{
    class State
    {
        Anim start;
        Anim sprite;
        Anim end;

        public State(Anim start, Anim sprite, Anim end)
        {
            this.start = start;
            this.sprite = sprite;
            this.end = end;
        }

        public Sprite Update()
        {
            if (start.Active())
            {
                return start.Update();
            }

            if (sprite.Active())
            {
                return sprite.Update();
            }
            
            if (end.Active())
            {
                return end.Update();
            }

            return null;
        }
    }
    
    private Queue<State> states = new Queue<State>();

    public Sprite[] spritesStart;
    public Sprite[] spritesEnd;
    
    Anim startAnim = new Anim(0.7f);
    Anim endAnim = new Anim(0.7f);

    private Image image;
    private static TextOutputWindow instance;
    public static TextOutputWindow GetInstance()
    {
        return instance;
    }

    private State current = null;

    public void push(Sprite sprite)
    {
        Debug.Log("push sprite");
        Anim spriteAnim = new Anim(2.5f);
        spriteAnim.sprites = new Sprite[1];
        spriteAnim.sprites[0] = sprite;
        states.Enqueue(new State(new Anim(startAnim), spriteAnim, new Anim(endAnim)));
    }

    void Start()
    {
        startAnim.sprites = spritesStart;
        endAnim.sprites = spritesEnd;
        
        instance = this;
        image = GetComponent<Image>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if (current == null)
        {
            if (states.Count > 0)
            {
                current = states.Dequeue();
            }
        }
        else
        {
            Sprite sprite = current.Update();
            if (!sprite)
            {
                current = null;
                return;
            }

            image.sprite = sprite;
        }
    } 
}
