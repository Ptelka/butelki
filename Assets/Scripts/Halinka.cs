using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Halinka : Clickable
{
    public GameObject exit;
    public TextUpdater updater;
    public GameObject policjant;
    
    private bool ispaid = false;
    public bool isPaid()
    {
        return ispaid;
    }

    public void OnScreenExit()
    {
        if (!isPaid() && Inventory.GetInstance().Contains("bottle"))
        {
            policjant.SetActive(true);
        }
    }
    
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        var inventory = Inventory.GetInstance(); 
    }

    public override void OnClick()
    {
        var inventory = Inventory.GetInstance();
        if (inventory.GetSelected() && inventory.GetSelected().collectibleName == "money")
        {
            updater.Trigger();
            inventory.Remove(inventory.GetSelected());
            ispaid = true;
        }
    }
}
