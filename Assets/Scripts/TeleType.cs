using UnityEngine;
using System.Collections;
using System.Collections.Generic;


namespace TMPro.Examples
{
    
    public class TeleType : MonoBehaviour
    {


        //[Range(0, 100)]
        //public int RevealSpeed = 50;

        public List<string> sentances;

        private int textNum = 0;

        private TMP_Text m_textMeshPro;

        bool newText = false;

        int counter = 0;

        void Awake()
        {
            // Get Reference to TextMeshPro Component
            m_textMeshPro = GetComponent<TMP_Text>();
            m_textMeshPro.text = sentances[textNum];
            m_textMeshPro.enableWordWrapping = true;
            //m_textMeshPro.alignment = TextAlignmentOptions.Top;
        }

        private void Update()
        {
            //m_textMeshPro.text = sentances[textNum];
            newText = false;

            //debugger
            //if (Input.GetKeyDown("l"))
            //{
            //    NextSentance();
            //}
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


        IEnumerator Start()
        {

            // Force and update of the mesh to get valid information.
            m_textMeshPro.ForceMeshUpdate();


            int totalVisibleCharacters = m_textMeshPro.textInfo.characterCount; // Get # of Visible Character in text object
            counter = 0;
            int visibleCount = 0;

            while (true)
            {
                visibleCount = counter % (totalVisibleCharacters + 1);

                m_textMeshPro.maxVisibleCharacters = visibleCount; // How many characters should TextMeshPro display?

                // Once the last character has been revealed, wait 1.0 second and start over.
                if (visibleCount >= totalVisibleCharacters)
                {                
                    yield return new WaitWhile(() => newText == false);
                    m_textMeshPro.text = sentances[textNum];
                }

                counter += 1;

                yield return new WaitForSeconds(0.05f);
            }

            //Debug.Log("Done revealing the text.");

        }
    }
}