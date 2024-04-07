using DG.Tweening;
using UnityEngine;

public class CubeRotator : MonoBehaviour
{
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private Vector3 _targetPosition;

    private void Awake()
    {
        _targetPosition = new Vector3(180f, 0f, 0f);
    }

    private void Start()
    {
        transform.DORotate(_targetPosition, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}
