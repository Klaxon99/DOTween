using UnityEngine;
using DG.Tweening;

public class ScaleChanger : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private float _scale;

    private void Start()
    {
        transform.DOScale(new Vector3(_scale, _scale, _scale), _duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}