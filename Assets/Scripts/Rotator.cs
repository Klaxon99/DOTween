using UnityEngine;
using DG.Tweening;

public class Rotator : DOTweenAnimator
{
    [SerializeField] private Vector3 _rotation;

    protected override Tween MakeAnimation()
    {
        return transform.DORotate(_rotation, Duration).SetEase(Ease.Linear);
    }
}