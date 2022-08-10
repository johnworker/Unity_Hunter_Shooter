using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace LEO {
 
    public class SystemDamage : MonoBehaviour
    {
        /// <summary>
        /// 傷害數字
        /// </summary>

        public float damage;

        [SerializeField, Header("大於 100 顏色")]
        private Color colorGratherThan100 = new Color(0.9f, 0.7f, 0.4f);
        [SerializeField, Header("大於 200 顏色")]
        private Color colorGratherThan200 = new Color(0.8f, 0.5f, 0.5f);

        private float limitUp;
        private float limitRight;
        private TextMeshProUGUI textDmage;

        private void Awake()
        {
            textDmage = GetComponentInChildren<TextMeshProUGUI>();
            textDmage.text = damage.ToString();

            if (damage >= 200) textDmage.color = colorGratherThan200;
            else if (damage >= 100) textDmage.color = colorGratherThan100;

            limitUp = Random.Range(50, 80);

            int r = Random.Range(0, 2);
            if (r == 0) limitRight = -50;
            else if (r == 1) limitRight = 50;

            StartCoroutine(MovementUp());
            StartCoroutine(MovementRight());
            StartCoroutine(ScaleEffect());

        }

        private IEnumerator MovementUp()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.up * limitUp;
                yield return new WaitForSeconds(0.01f);
            }

            for (int i = 0; i < 3; i++)
            {
                transform.position -= transform.up * limitUp;
                yield return new WaitForSeconds(0.01f);
            }

            for (int i = 0; i < 10; i++)
            {
                textDmage.color -= new Color(0, 0, 0, 0.1f);
                yield return new WaitForSeconds(0.01f);
            }

        }

        private IEnumerator MovementRight()
        {
            for (int i = 0; i < 10; i++)
            {
                transform.position += transform.right * limitRight;
                yield return new WaitForSeconds(0.02f);
            }
        }

        private IEnumerator ScaleEffect()
        {
            for (int i = 0; i < 5; i++)
            {
                transform.localScale += Vector3.one * 0.001f;
                yield return new WaitForSeconds(0.01f);
            }

            for (int i = 0; i < 5; i++)
            {
                transform.localScale -= Vector3.one * 0.001f;
                yield return new WaitForSeconds(0.01f);
            }

        }

    }

}