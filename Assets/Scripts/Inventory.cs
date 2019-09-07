using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour
{
    private static Inventory instance;
    public static Inventory GetInstance()
    {
        return instance;
    }

    public GameObject[] canvasInventory;
    public List<Collectible> collectibles;

    public void Add(Collectible collectible)
    {
        if (collectibles.Count >= canvasInventory.Length)
        {
            Debug.Log("Full inventory");
            return;
        }

        var id = collectibles.Count;
        collectibles.Add(collectible);
        collectible.OnAdd(canvasInventory[id]);
    }

    public void Remove(Collectible collectible)
    {
        if (!collectibles.Contains(collectible))
        {
            return;
        }

        for (int i = 0; i < canvasInventory.Length; i++)
        {
            canvasInventory[i].GetComponent<InventorySlot>().RemoveCollectible();
        }
        
        var id = collectibles.IndexOf(collectible);
        collectibles.Remove(collectible);
        List<Collectible> cpy = new List<Collectible>(collectibles);
        collectibles.Clear();

        foreach (var c in cpy)
        {
            Add(c);
        }
        
        collectible.OnRemove(canvasInventory[id]);
    }
    
    void Start()
    {
        instance = this;
    }


    void Update()
    {
        
    }
}
