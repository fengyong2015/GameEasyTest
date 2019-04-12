using System;
using Game.EasyTest;
using UnityEngine;

public class GameEasyTest_SrorageItem : GameEasyTestBase
{
    private const string ItemsDes = "水果";
    private const string actionDes = "增加";

    protected override void InitData()
    {
        string[] items = {"苹果", "桔子", "香蕉", "芒果", "西瓜"};
        easyTestData.Add(GameEasyTestFacory.StorageItem(ItemsDes, actionDes, items, Save));
    }

    void Save(string pName, int pNumber)
    {
        Debug.LogError(string.Format("{0}{1}{2}个", actionDes, pName, pNumber));
    }
}