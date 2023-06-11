using System;
using System.IO.Compression;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    private Transform player;

    public void Awake()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            player = GameObject.FindGameObjectWithTag("Player").transform;
        }
       
    }


    public void Start()
    {
        ItemEvents.onEnableItem(this.gameObject);
        if (GameObject.FindGameObjectWithTag("Item") != null)
        {
            transform.parent = GameObject.FindGameObjectWithTag("Item").transform;
        }
       
    }
    

   public void Update()
   {
       transform.GetChild(1).gameObject.SetActive((player.position - transform.position).magnitude < 2);
   }
}
