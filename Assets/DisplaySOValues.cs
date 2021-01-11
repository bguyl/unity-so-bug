using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

public class DisplaySOValues : MonoBehaviour
{
	[Header("Atom SO")]
	[SerializeField] private FloatVariable _atomSO;
	[SerializeField] private Text _atomText;

	[Header("Vanilla SO")]
	[SerializeField] private VanillaFloatSO _vanillaSO;
	[SerializeField] private Text _vanillaText;
	
	[Header("Vanilla Global SO")]
	[SerializeField] private VanillaFloatSO _vanillaGlobalSO;
	[SerializeField] private Text _vanillaGlobalText;

	private void LateUpdate()
	{
		if (_atomText != null && _atomSO != null)
		{
			_atomText.text = _atomSO.Value.ToString();	
		}

		if (_vanillaGlobalText != null && _vanillaSO != null)
		{
			_vanillaText.text = _vanillaSO.Value.ToString();	
		}

		if (_vanillaGlobalText != null && _vanillaGlobalText != null)
		{
			_vanillaGlobalText.text = _vanillaGlobalSO.Value.ToString();	
		}
	}
}
