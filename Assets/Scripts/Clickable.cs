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
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);
            if (hit && hit.collider == collider)
            {
                Debug.Log("On click " + gameObject);
                OnClick();
            }
        }
        
        if (collider.bounds.Contains(mousePosition))
        {
            transform.localScale = scale * 1.1f;
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
