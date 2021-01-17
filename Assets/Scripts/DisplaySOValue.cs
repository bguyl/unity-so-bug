using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Show either Atom or Vanilla SO float value
/// </summary>
[RequireComponent(typeof(Text))]
public class DisplaySOValue : MonoBehaviour
{
	[Header("Show Atom value OR Vanilla value")]
	[SerializeField] private FloatVariable _atomSO;
	[SerializeField] private VanillaFloatSO _vanillaSO;
	private Text _text;

	private void Awake()
	{
		_text = GetComponent<Text>();
	}

	private void LateUpdate()
	{
		if (_text != null && _atomSO != null)
		{
			_text.text = _atomSO.Value.ToString();	
		}
		else if (_text != null && _vanillaSO != null)
		{
			_text.text = _vanillaSO.Value.ToString();	
		}
	}
}
