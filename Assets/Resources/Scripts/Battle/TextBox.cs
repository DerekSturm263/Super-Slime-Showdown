using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public static float timePerLetter = 0.1f;

    public static void WriteText(TMPro.TMP_Text textBox, string text)
    {
        textBox.gameObject.SetActive(true);
        StartCoroutine(WriteByLetter(textBox, text));
    }

    private IEnumerator WriteByLetter(TMPro.TMP_Text textBox, string text)
    {
        string newText = "";

        for (int i = 0; i < text.Length; i++)
        {
            newText += text[i];
            textBox.text = newText;
            yield return new WaitForSeconds(timePerLetter);
        }
    }

    private static void ClearText(TMPro.TMP_Text textBox)
    {
        textBox.text = "";
        textBox.gameObject.SetActive(false);
    }
}
