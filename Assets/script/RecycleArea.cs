using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LEO
{
    /// <summary>
    /// �^���ϰ�
    /// </summary>
    public class RecycleArea : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains("�u�]"))
            {
                print("�^���u�]");
            }
        }


    }
}