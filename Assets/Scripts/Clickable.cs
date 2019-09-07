using System;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{
    private Collider2D collider;
    private Vector3 scale;

    public void Start()
    {
        collider = GetComponent<Collider2D>();
        scale = transform.localScale;
    }
    
    private void FixedUpdate()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
        if (hit && hit.collider == collider)
        {
            transform.localScale = scale * 1.1f;
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("On click " + gameObject);
                OnClick();
            }
        }
        else
        {
            transform.localScale = scale;
        }
    }

    public virtual void OnClick()
    {
    }
}
