using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Game.EasyTest
{
    [CustomEditor(typeof(GameEasyTestBase), true)]
    public class GameEasyTestEditor : Editor
    {
        private GameEasyTestBase _tTarget;

        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (!Application.isPlaying) return;
            if (_tTarget == null) _tTarget = target as GameEasyTestBase;
            if (_tTarget == null) return;
            if (_tTarget.easyTestData == null) return;

            foreach (var item in _tTarget.easyTestData)
            {
                item.Rendering();
                GUILayout.Space(10);
            }
        }
    }
}