using UnityEngine;

[RequireComponent (typeof(Renderer))]
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color _initialColor = Color.white;
    [SerializeField] private Color _touchedColor = Color.red;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnEnable()
    {
        SetDefault();
    }

    public void Change()
    {
        _renderer.material.color = _touchedColor;
    }

    private void SetDefault()
    {
        _renderer.material.color = _initialColor;
    }
}
