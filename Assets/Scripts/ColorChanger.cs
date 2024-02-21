using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private Image _image;
    [SerializeField] private float _duration;

    private void Start()
    {
        _image.DOColor(_color, _duration);
    }
}