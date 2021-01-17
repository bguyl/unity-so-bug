using System;
using System.Collections;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Make Raise text appear
/// </summary>
[RequireComponent(typeof(Text))]
public class DisplaySOEvent : MonoBehaviour
{
	[SerializeField] private VoidEvent _voidEvent;
	[SerializeField] private float _eventTime = 0.5f;
	private Text _text;
	private Coroutine _coroutine = null;

	private void Awake()
	{
		_text = GetComponent<Text>();
	}

	private void OnEnable()
	{
		_voidEvent?.Register(Show);
	}

	private void OnDisable()
	{
		_voidEvent?.Unregister(Show);
	}

	private void Show()
	{
		if (_coroutine != null)
		{
			StopCoroutine(_coroutine);
		}

		_coroutine = StartCoroutine(ToastAnimation());
	}

	private IEnumerator ToastAnimation()
	{
		float alpha = 1f;
		float timer = 0f;

		while (alpha > 0f)
		{
			alpha = Mathf.Lerp(1f, 0f, timer / _eventTime);
			timer += Time.deltaTime;
			Color nextColor = new Color(_text.color.r, _text.color.g, _text.color.b, alpha); 
			_text.color = nextColor; 
			yield return null;
		}
	}
}
