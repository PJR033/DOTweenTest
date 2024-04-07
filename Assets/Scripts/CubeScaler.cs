using DG.Tweening;
using UnityEngine;

public class CubeScaler : MonoBehaviour
{
    [SerializeField] private float _scaleValue;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOScale(_scaleValue, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}
