using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class derFloorManager : MonoBehaviour
{
    public GameObject slots;

    [SerializeField]
    public List<GameObject> slotsObjects;


    public Sprite sprite_1;
    public Sprite sprite_2;
    public Sprite sprite_3;
    public Sprite sprite_4;
    public Sprite sprite_5;
    public Sprite sprite_6;
    public Sprite sprite_7;
    public Sprite sprite_8;
    public Sprite sprite_9;
    public Sprite sprite_10;
    public Sprite sprite_11;


    // Start is called before the first frame update
    void Start()
    {
        sprite_1 = Resources.Load<Sprite>("sprites/1");
        sprite_2 = Resources.Load<Sprite>("sprites/1");
        sprite_3 = Resources.Load<Sprite>("sprites/3");
        sprite_4 = Resources.Load<Sprite>("sprites/4");
        sprite_5 = Resources.Load<Sprite>("sprites/5");
        sprite_6 = Resources.Load<Sprite>("sprites/6");
        sprite_7 = Resources.Load<Sprite>("sprites/420");
        sprite_8 = Resources.Load<Sprite>("sprites/SPOILER_woobi");
        sprite_9 = Resources.Load<Sprite>("sprites/lampe");
        sprite_10 = Resources.Load<Sprite>("sprites/leiter");
        sprite_11 = Resources.Load<Sprite>("sprites/lunte");

        slots = GameObject.Find("Slots");

        foreach (Transform child in slots.transform)
        {
            slotsObjects.Add(child.gameObject);            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
