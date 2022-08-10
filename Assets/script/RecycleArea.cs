using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LEO
{
    /// <summary>
    /// 回收區域
    /// </summary>
    public class RecycleArea : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains("彈珠"))
            {
                print("回收彈珠");
            }
        }


    }
}