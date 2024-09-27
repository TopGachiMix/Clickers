using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public TextSave textSaver;
    public TextLoader textLoader;
    public InputField inputField;
    public Text displayText; // Для отображения загруженного текста

    public void OnSaveButtonClicked()
    {
        string inputText = inputField.text;
        textSaver.SaveText("MyText", inputText);
    }

    public void OnLoadButtonClicked()
    {
        string loadedText = textLoader.LoadText("MyText");
        displayText.text = loadedText; // Отображаем загруженный текст
    }
}