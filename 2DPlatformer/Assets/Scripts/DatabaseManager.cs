﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    public List<Item> itemList = new List<Item>();
    void Start()
    {
        itemList.Add(new Item(10001,"주문서", "이이이잉", Item.ItemType.Quest));
        //itemList.Add(new Item(10002,"책", "ㅁㄴ리ㅏㅓㅁ;ㅣ러", Item.ItemType.Quest));
        itemList.Add(new Item(10003,"빨간 폰션", "체력 50", Item.ItemType.Combat));
        //itemList.Add(new Item(10004,"파란 폰션", "마나 50", Item.ItemType.Combat));
    }

    // Update is called once per frames
    void Update()
    {
        
    }
}