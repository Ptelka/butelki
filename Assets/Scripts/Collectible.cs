using UnityEngine;
using UnityEngine.UI;

public class Collectible : Clickable
{
    private bool isInInventory = false;
    private GameObject canvas;

    public void OnAdd(GameObject canvasObject)
    {
        canvas = canvasObject;
        canvasObject.GetComponent<InventorySlot>().SetCollectible(this);
    }

    public void OnRemove(GameObject canvasObject)
    {
        Debug.Log("removing from inventory " + gameObject);
        canvas = null;
        gameObject.SetActive(false);
    }

    override public void OnClick()
    {
        if (!canvas)
        {
            Inventory.GetInstance().Add(this);
        }
    }
    
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        if (canvas)
        {
            transform.position = canvas.transform.position;
        }
    }
}
