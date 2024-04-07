using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextChanger : MonoBehaviour
{
    [SerializeField] private Text _text;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();
        Tween replacementText = _text.DOText("Кубы флексят", _duration).SetEase(Ease.Linear);
        Tween addingText = _text.DOText(". Кубы на приколе", _duration).SetRelative().SetEase(Ease.Linear);
        Tween bustingText = _text.DOText("КУБЫ ЖОСКО РОФЛЯТ", _duration, true, ScrambleMode.All).SetEase(Ease.Linear);

        sequence.Append(replacementText);
        sequence.Append(addingText);
        sequence.Append(bustingText);
        sequence.SetLoops(_repeats, _loopType);
    }
}
