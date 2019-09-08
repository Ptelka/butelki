using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : Collectible
{
    // Start is called before the first frame update
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    public override void OnClick()
    {
        var collectible = Inventory.GetInstance().GetSelected().GetComponent<InventorySlot>().GetCollectible();
        if (collectible && collectible.collectibleName == "people")
        {
            base.OnClick();
        }
    }
}
