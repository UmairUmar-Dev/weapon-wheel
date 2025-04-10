using UnityEngine;
using UnityEngine.UI;

public class WheelManager : MonoBehaviour
{
    [SerializeField] private Button _openWheel;
    [SerializeField] private Button _closeWheel;
    private void Start()
    {
        _openWheel.onClick.AddListener(OpenWheel);
        _closeWheel.onClick.AddListener(CloseWheel);
    }
    private void OpenWheel()
    {
        WeaponWheelController.Instance.OpenWheel();
    }
    private void CloseWheel()
    {
        WeaponWheelController.Instance.CloseWheel();
    }
}
