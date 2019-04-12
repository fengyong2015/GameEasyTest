using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.EasyTest
{
    [Serializable]
    public abstract class GameEasyTestBase : MonoBehaviour
    {
        public List<IEasyTest> easyTestData;

        protected virtual void Start()
        {
#if UNITY_EDITOR
            easyTestData = new List<IEasyTest>();
            InitData();
#endif
        }

        /// <summary>
        /// 初始化需要处理的条目数据
        /// </summary>
        protected virtual void InitData()
        {
            
        }
    }
}