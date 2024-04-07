using DG.Tweening;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private Transform _targetPosition;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private void Start()
    {
        transform.DOMove(_targetPosition.position, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}
