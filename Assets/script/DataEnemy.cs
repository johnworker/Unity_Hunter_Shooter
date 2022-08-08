using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LEO
{

    // ScriptableObject 腳本化物件：腳本內容變成物件資料存放在 project 內
    // 必須搭配 CreateAssetMenu

    [CreateAssetMenu(menuName = "LEO/Data Enemy", fileName = "Data Enemy")]
    public class DataEnemy : ScriptableObject
    {

    }

}