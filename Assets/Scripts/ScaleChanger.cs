using UnityEngine;
using DG.Tweening;

public class ScaleChanger : DOTweenAnimator
{
    [SerializeField] private float _scale;

    protected override Tween MakeAnimation()
    {
        return transform.DOScale(new Vector3(_scale, _scale, _scale), Duration).SetEase(Ease.Linear);
    }
}