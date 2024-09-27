using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class floatingText : MonoBehaviour
{
    public TextMesh FloatingText;
    [HideInInspector] public int Clicks;
    void Start()
    {
            FloatingText = GetComponent<TextMesh>();

    }

    private void Update()
    {
        FloatingText.text = $"+ {Clicks}";
    }


    private void OnAnimation()
    {
            Destroy(gameObject);
    }
}
