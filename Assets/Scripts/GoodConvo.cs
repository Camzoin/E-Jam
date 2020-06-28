using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace TMPro.Examples
{
    
    public class GoodConvo : MonoBehaviour
    {
        //[Range(0, 100)]
        //public int RevealSpeed = 50;

        public List<string> sentances;

        public int textNum = 0;

        private TMP_Text m_textMeshPro;

        public bool newText = false;

        int counter = 0;

        public string speech;

        public bool outsideTrig = false;

        void Awake()
        {
            // Get Reference to TextMeshPro Component
            m_textMeshPro = GetComponent<TMP_Text>();
            m_textMeshPro.text = sentances[textNum];
            //m_textMeshPro.enableWordWrapping = true;
            //m_textMeshPro.alignment = TextAlignmentOptions.Top;
        }

        private void Update()
        {
            m_textMeshPro.text = sentances[textNum];

            //m_textMeshPro.text = sentances[textNum];
            newText = false;

            //debugger
            if (outsideTrig == true)
            {
                NextSentance();
                outsideTrig = false;
            }

        }

        public void NextSentance()
        {
            if (textNum + 2 <= sentances.Count)
            {
                
                textNum = textNum + 1;
                newText = true;
            }

            else

            
            textNum = 0;
            newText = true;
        }
    }
}