using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu(fileName = "VanillaFloatSO", menuName = "VanillaFloatSO", order = 0)]
public class VanillaFloatSO : ScriptableObject
{
	[SerializeField] private bool _global = false;
	[SerializeField] private bool _scene = false;
	[SerializeField] private float _initialValue = 0f;
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
		else if (_scene)
		{
			SceneManager.activeSceneChanged += OnActiveSceneChanged;
		}

		_value = _initialValue;
	}

	private void OnDisable()
	{
		SceneManager.activeSceneChanged -= OnActiveSceneChanged;
	}

	public void Reset()
	{
		_value = _initialValue;
	}

	public void Add(float parameter)
	{
		Value += parameter;
	}
	
	private void OnActiveSceneChanged(Scene previousScene, Scene nextScene)
	{
		Reset();	
	}
}