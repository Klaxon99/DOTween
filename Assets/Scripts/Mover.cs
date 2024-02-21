using DG.Tweening;
using UnityEngine;

public class Mover : DOTweenAnimator
{
    [SerializeField] private Vector3 _targetPosition;

    protected override Tween MakeAnimation()
    {
        return transform.DOMove(_targetPosition, Duration).SetEase(Ease.Linear);
    }
}