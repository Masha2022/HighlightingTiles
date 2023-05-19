using UnityEngine;

public class SelectedTile : MonoBehaviour
{
    private Color _originalColor;
    private Renderer _renderer;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        _originalColor = _renderer.material.color;
    }

    private void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hit))
        {
            if (hit.collider.gameObject == gameObject)
            {
                _renderer.material.color = Color.gray;
            }
            else
            {
                _renderer.material.color = _originalColor;
            }
        }
    }
}