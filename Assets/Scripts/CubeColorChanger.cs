using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class CubeColorChanger : MonoBehaviour
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;
    [SerializeField] private int _repeats;
    [SerializeField] private LoopType _loopType;

    private MeshRenderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    private void Start()
    {
        _renderer.material.DOColor(_color, _duration).SetLoops(_repeats, _loopType).SetEase(Ease.Linear);
    }
}
