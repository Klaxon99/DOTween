using DG.Tweening;
using UnityEngine;

public abstract class DOTweenAnimator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private LoopType _loopType;

    protected float Duration => _duration;

    private void Start()
    {
        MakeAnimation().SetLoops(-1, _loopType);
    }

    protected abstract Tween MakeAnimation();
}