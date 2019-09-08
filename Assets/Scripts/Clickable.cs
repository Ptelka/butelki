using System;
using UnityEngine;
using UnityEngine.UI;

public class Clickable : MonoBehaviour
{
    private Collider2D collider;
    private Vector3 scale;

    public void Start() {
        collider = GetComponent<Collider2D>();
        scale = transform.localScale;
    }

    void FixedUpdate()
    {
        if (TextOutputWindow.GetInstance().IsOpened())
        {
            return;
        }
        var mpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mpos.z = transform.position.z;
        var contains = collider.bounds.Contains(mpos);
        if (Input.GetMouseButtonDown(0) && contains)
        {
            Debug.Log("On click " + gameObject);
            OnClick();
        }
        
        transform.localScale = contains ? scale * 1.1f : scale;
    }

    public virtual void OnClick() { }
}
