using System;
using System.Globalization;
using Scenes;
using UnityAtoms.BaseAtoms;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class DisplaySOValue : MonoBehaviour
{
	public FloatVariable so;
	private Text text;

	private void Awake()
	{
		text = GetComponent<Text>();
	}

	private void LateUpdate()
	{
		text.text = so.Value.ToString(CultureInfo.InvariantCulture);
	}
}
