using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private float _delay;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        sequence.Append(_text.DOText("Заменил этот текст!!", _duration));
        sequence.Append(_text.DOText("Дополнение к тексту", _duration).SetDelay(_delay).SetRelative());
        sequence.Append(_text.DOText("я взломал этот текст!!!", _duration, true, ScrambleMode.All).SetDelay(_delay));
    }
}