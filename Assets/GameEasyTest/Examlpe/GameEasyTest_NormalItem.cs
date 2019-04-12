using Game.EasyTest;
using UnityEngine;

public class GameEasyTest_NormalItem : GameEasyTestBase
{
    private const string ActionDes = "在控制台打印";

    protected override void InitData()
    {
        easyTestData.Add(GameEasyTestFacory.NormalItem(ActionDes, Print));
    }

    void Print()
    {
        Debug.LogError(ActionDes);
    }
}