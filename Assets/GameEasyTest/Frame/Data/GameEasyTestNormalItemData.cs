using System;
using UnityEngine;

namespace Game.EasyTest
{
    public class GameEasyTestNormalItemData : IEasyTest
    {
        public string actionDescription { get; private set; }
        public Action action;

        public GameEasyTestNormalItemData(string pActionDes, Action pAction)
        {
            actionDescription = pActionDes;
            action = pAction;
        }

        public void Run()
        {
            if (action != null) action();
        }

        public void Rendering()
        {
            if (GUILayout.Button(actionDescription)) Run();
        }
    }
}