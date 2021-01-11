using UnityEngine;
using UnityEngine.EventSystems;
using UnityAtoms.BaseAtoms;

public class IncrementOnClick : MonoBehaviour, IPointerClickHandler
{
	[SerializeField] private FloatVariable _atomFloat;
	[SerializeField] private VanillaFloatSO _vanillaFloat;

	public void OnPointerClick(PointerEventData eventData)
	{
		if (_atomFloat != null)
		{
			_atomFloat.Add(1f);
		}

		if (_vanillaFloat != null)
		{
			_vanillaFloat.Add(1f);
		}
	}
}
