using UnityEngine;
using UnityEngine.UI;

public class GetWaterButton : MonoBehaviour
{
    Button _button;

    private void Start()
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ButtonClick);
    }

    void ButtonClick()
    {
        Managers.Game.GetWater();
    }
}
