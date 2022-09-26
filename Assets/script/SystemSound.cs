using UnityEngine;

namespace LEO
{
    /// <summary>
    /// 音效系統：提供撥放聲音的功能
    /// </summary>
    // 要求元件(類型(元件1)，類型(元件2)，...)
    // 套用此腳本至遊戲物件時候會執行
    [RequireComponent(typeof(AudioSource))]
    public class SystemSound : MonoBehaviour
    {
        // 如果其他系統需要與此溝通可以使用此寫法
        // 定義一個與此腳本相同的欄位設為靜態
        // 名稱習慣會用 instance 實體
        public static SystemSound instance;

        private AudioSource aud;

        private void Awake()
        {
            // Awake 或 Start 將欄位指為此腳本
            instance = this;
            aud = GetComponent<AudioSource>();
        }

        /// <summary>
        /// 播放音效
        /// </summary>
        /// <param name="sound"></param>
        /// <param name="rangeVolum"></param>
        public void PlaySound(AudioClip sound, Vector2 rangeVolum)
        {
            // 取得隨機範圍的音量
            float volum = Random.Range(rangeVolum.x, rangeVolum.y);
            // 音效元件,播放一次音效(音效，音量)
            aud.PlayOneShot(sound, volum);
        }
    }

}
