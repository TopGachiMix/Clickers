using UnityEngine.UI;
using UnityEngine;

public class TextSave : MonoBehaviour
{
   // Метод для сохранения текста
    public void SaveText(string key, string value)
    {
        PlayerPrefs.SetString(key, value);
        PlayerPrefs.Save(); // Сохраняем изменения
        Debug.Log("Text saved: " + value);
    }
}
