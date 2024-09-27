using UnityEngine;

public class TextLoader : MonoBehaviour
{
    // Метод для загрузки текста
    public string LoadText(string key)
    {
        string value = PlayerPrefs.GetString(key, "Default Value"); // Возвращает "Default Value", если ключ не найден
        Debug.Log("Text loaded: " + value);
        return value;
    }
}