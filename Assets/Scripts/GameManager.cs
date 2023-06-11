using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using static ItemEvents;

public class GameManager : MonoBehaviour
{
   [SerializeField] private List<GameObject> itemList;

   
  
   private void OnEnable()
   {
       onEnableItem += WriteToListItem;
       onDisableItem += RemoveFromListItem;
   }

   private void OnDisable()
   {
       onEnableItem -= WriteToListItem;
       onDisableItem -= RemoveFromListItem;
   }


   private void WriteToListItem(GameObject item)
   {
       itemList.Add(item);
   }

   private void RemoveFromListItem(GameObject item)
   {
       itemList.Remove(item);
   }
}
