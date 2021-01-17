using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/// <summary>
/// Simply display SceneName
/// </summary>
[RequireComponent(typeof(Text))]
public class SceneName : MonoBehaviour
{
	private void Start()
	{
		GetComponent<Text>().text = SceneManager.GetActiveScene().name;
	}
}
