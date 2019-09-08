using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour     , IPointerClickHandler 
    , IDragHandler
    , IPointerEnterHandler
    , IPointerExitHandler
{
    private Collectible collectible;
    private Vector3 scale;
    public Collectible GetCollectible()
    {
        return collectible;
    }
    void Start()
    {
        scale = transform.localScale;
    }

    public void SetCollectible(Collectible c)
    {
        gameObject.SetActive(true);
        collectible = c;
        var image = GetComponent<Image>();
        image.sprite = c.GetComponent<SpriteRenderer>().sprite;
    }

    public void RemoveCollectible(){
        GetComponent<Image>().sprite = null;
        gameObject.SetActive(false);
        collectible = null;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click");
        Inventory.GetInstance().Select(gameObject);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (collectible)
        {
            Debug.Log("Drag");
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = scale * 1.1f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = scale;
    }
}
