using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class People : Clickable
{
    public TextUpdater piwo;
    new void Start()
    {
        base.Start();
    }

    public override void OnClick()
    {
        var inventory = Inventory.GetInstance();
        if (inventory.GetSelected())
        {
            if (inventory.GetSelected().name == "bottle")
            {
                piwo.Trigger();
                inventory.Remove(inventory.GetSelected());
            }
        }
    }
}
