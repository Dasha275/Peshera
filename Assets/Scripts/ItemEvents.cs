using System;
using UnityEngine;


public static class ItemEvents 
{
    public static Action<GameObject> onEnableItem, onDisableItem;

    public static void ActionOnEnable(GameObject item)
    {
        onEnableItem?.Invoke(item);
    }

    
    
}
