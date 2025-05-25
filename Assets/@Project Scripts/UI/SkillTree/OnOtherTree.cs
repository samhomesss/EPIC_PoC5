using UnityEngine;
using UnityEngine.UI;

public class OnOtherTree : MonoBehaviour
{
    Button _button;
    public GameObject tree2;
    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        tree2.SetActive(true);
    }
}
