using UnityEngine;

public class Anim
{
    private float timer;
    private float time;
    public Sprite[] sprites;

    public Anim(Anim a)
    {
        timer = 0;
        time = a.time;
        sprites = a.sprites;
    }
    public Anim(float time)
    {
        this.time = time;
    }
    
    public void Start()
    {
        timer = 0;
    }
        
    public bool Active()
    {
        return sprites.Length > 0 && timer <= time;
    }

    public Sprite Update()
    {
        var x = time / sprites.Length;
        Sprite result = null;
        for (int i = 0; i < sprites.Length; i++)
        {
            if (i * x <= timer)
            {
                result = sprites[i];
            }
        }
        timer += Time.deltaTime;
        return result;
    }
}