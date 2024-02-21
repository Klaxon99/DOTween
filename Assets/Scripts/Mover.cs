using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _targetPosition;

    private void Start()
    {
        transform.DOMove(_targetPosition, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
