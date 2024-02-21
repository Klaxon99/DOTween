using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ColorChanger : DOTweenAnimator
{
    [SerializeField] private Color _color;
    [SerializeField] private Image _image;

    protected override Tween MakeAnimation()
    {
        return _image.DOColor(_color, Duration);
    }
}