using UnityEngine;

public class Switch_cam : MonoBehaviour
{
    [SerializeField] private GameObject _cam1;
    [SerializeField] private GameObject _cam2;

    public void Switch_c()
    {
        if (_cam1.activeSelf)
        {
            _cam1.SetActive(false);
            _cam2.SetActive(true);
        }
        else
        {
            _cam1.SetActive(true);
            _cam2.SetActive(false);
        }
    }
}
