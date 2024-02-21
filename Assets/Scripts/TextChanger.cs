using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : DOTweenAnimator
{
    [SerializeField] private Text _text;
    [SerializeField] private float _delay;

    protected override Tween MakeAnimation()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("Заменил этот текст!!", Duration));
        sequence.Append(_text.DOText("Дополнение к тексту", Duration).SetDelay(_delay).SetRelative());
        sequence.Append(_text.DOText("я взломал этот текст!!!", Duration, true, ScrambleMode.All).SetDelay(_delay));

        return sequence;
    }
}