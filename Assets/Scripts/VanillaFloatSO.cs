using UnityEngine;

[CreateAssetMenu(fileName = "VanillaFloatSO", menuName = "VanillaFloatSO", order = 0)]
public class VanillaFloatSO : ScriptableObject
{
	[SerializeField] private bool _global = false;
	[SerializeField] private float _value = 0f;

	public float Value
	{
		get => _value;
		set => _value = value;
	}

	private void OnEnable()
	{
		if (_global)
		{
			hideFlags = HideFlags.DontUnloadUnusedAsset;	
		}
	}

	public void Add(float parameter)
	{
		Value += parameter;
	}
}