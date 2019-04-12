using System;
using UnityEditor;
using UnityEngine;

namespace Game.EasyTest
{
    public class GameEasyTestStorageItemData : IEasyTest
    {
        public string itemDescription { get; private set; }
        public string actionDescription { get; private set; }

        public string[] items { get; private set; }
        public int actionNumber { get; set; }
        public int currentIndex { get; set; }

        public Action<string, int> action { get; set; }

        public GameEasyTestStorageItemData(string pItemDescription, string pActionDescription, string[] pItems)
        {
            itemDescription = pItemDescription;
            actionDescription = pActionDescription;
            items = pItems;
            actionNumber = 1;
        }

        public void Rendering()
        {
            EditorGUILayout.BeginHorizontal();
            GUILayout.Label(itemDescription);
            currentIndex = EditorGUILayout.Popup(currentIndex, items);
            GUILayout.Label(actionDescription);
            actionNumber = EditorGUILayout.IntField(actionNumber);
            if (GUILayout.Button("执行")) Run();
            EditorGUILayout.EndHorizontal();
        }

        public void Run()
        {
            if (action != null)
            {
                action(items[currentIndex], actionNumber);
            }
        }
    }
}