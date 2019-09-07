using System;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{
    private Collider2D collider;

    public void Start()
    {
        collider = GetComponent<Collider2D>();
    }
    
    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit && hit.collider == collider) {
                Debug.Log("On click " + gameObject);
                OnClick();
            }
        }
    }

    public virtual void OnClick()
    {
    }
}
