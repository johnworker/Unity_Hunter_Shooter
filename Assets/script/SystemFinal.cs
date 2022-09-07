using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace LEO
{
    /// <summary>
    /// �C�������t�ΡG�ӧQ�P����
    /// </summary>
    public class SystemFinal : MonoBehaviour
    {
        /// <summary>
        /// �C�������e��
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// �C�������p���D
        /// </summary>
        private TextMeshProUGUI textSubTitle;
        /// <summary>
        /// ���s�C��
        /// </summary>
        private Button btnReplay;
        /// <summary>
        /// ���}�C��
        /// </summary>
        private Button btnQuit;

        private void Awake()
        {
            groupFinal = GameObject.Find("�C�������e��").GetComponent<CanvasGroup>();
            textSubTitle = GameObject.Find("�C�������p���D").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
            btnQuit = GameObject.Find("���}�C��").GetComponent<Button>();
        }
    }

}
