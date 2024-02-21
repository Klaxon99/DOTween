using UnityEngine;
using DG.Tweening;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private Vector3 _rotation;

    private void Start()
    {
        transform.DORotate(_rotation, _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}