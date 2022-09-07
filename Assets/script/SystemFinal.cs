using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace LEO
{
    /// <summary>
    /// 遊戲結束系統：勝利與失敗
    /// </summary>
    public class SystemFinal : MonoBehaviour
    {
        /// <summary>
        /// 遊戲結束畫面
        /// </summary>
        private CanvasGroup groupFinal;
        /// <summary>
        /// 遊戲結束小標題
        /// </summary>
        private TextMeshProUGUI textSubTitle;
        /// <summary>
        /// 重新遊戲
        /// </summary>
        private Button btnReplay;
        /// <summary>
        /// 離開遊戲
        /// </summary>
        private Button btnQuit;

        private void Awake()
        {
            groupFinal = GameObject.Find("遊戲結束畫面").GetComponent<CanvasGroup>();
            textSubTitle = GameObject.Find("遊戲結束小標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnQuit = GameObject.Find("離開遊戲").GetComponent<Button>();
        }
    }

}
