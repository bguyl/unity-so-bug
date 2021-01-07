namespace Scenes
{
	using System;
	using UnityEngine;

	[CreateAssetMenu(fileName = "BasicSO", menuName = "BasicSO", order = 0)]
	public class BasicSO : ScriptableObject
	{
		private void OnEnable()
		{
			hideFlags = HideFlags.DontUnloadUnusedAsset;
		}

		public float value = 0f;

		public void Add()
		{
			value += 1f;
		}
	}
}