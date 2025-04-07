namespace OTO.Manager
{
    //System
    using System;
    using System.Collections.Generic;
    
    //UnityEngine
    using UnityEngine;


    //풀 오브젝트 데이터 클래스
    [Serializable]
    public class PoolObjectData
    {
        public GameObject poolPrefabObject = null;
        public int poolCount = default;
        [HideInInspector] public Queue<GameObject> poolObjectContainer = new Queue<GameObject>();
    }
}
