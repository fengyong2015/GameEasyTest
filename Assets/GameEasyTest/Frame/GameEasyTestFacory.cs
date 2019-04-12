using System;

namespace Game.EasyTest
{
    public static class GameEasyTestFacory
    {
        /// <summary>
        /// 创建库存类数据，选择物品，输入数量，点击执行action
        /// </summary>
        /// <param name="pItemsDes">物品集合描述</param>
        /// <param name="pActionDes">行为</param>
        /// <param name="pItems">物品列表</param>
        /// <param name="pAction">行为</param>
        /// <returns></returns>
        public static IEasyTest StorageItem(string pItemsDes, string pActionDes, string[] pItems,
            Action<string, int> pAction)
        {
            var _SpecialGoodsIncreace = new GameEasyTestStorageItemData(pItemsDes, pActionDes, pItems);
            _SpecialGoodsIncreace.action += pAction;
            return _SpecialGoodsIncreace;
        }

        /// <summary>
        ///  创建普通数据，点击执行action
        /// </summary>
        /// <param name="pActionDes">行为描述</param>
        /// <param name="pAction">行为</param>
        /// <returns></returns>
        public static IEasyTest NormalItem(string pActionDes, Action pAction)
        {
            var _SpecialGoodsIncreace = new GameEasyTestNormalItemData(pActionDes, pAction);
            return _SpecialGoodsIncreace;
        }
    }
}