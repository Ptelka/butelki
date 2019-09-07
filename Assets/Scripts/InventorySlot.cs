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
        Inventory.GetInstance().Remove(collectible);
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (collectible)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Debug.Log("Drag");
            collectible.gameObject.transform.position = mousePosition;
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
