using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class SceneOrchestration : MonoBehaviour
{
	private static SceneOrchestration _instance;
	public static SceneOrchestration Instance => _instance;

	[SerializeField] private AssetReference _firstScene;
	private AssetReference _currentScene = null;
	
	private void Awake()
	{
		if (_instance == null)
		{
			_instance = this;
			DontDestroyOnLoad(gameObject);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	private void Start()
	{
		LoadScene(_firstScene);
	}

	public static async void LoadScene(AssetReference _scene)
	{
		if (_instance._currentScene != null)
		{
			await Instance._currentScene.UnLoadScene().Task;	
		}
		Instance._currentScene = _scene;
		await Instance._currentScene.LoadSceneAsync(LoadSceneMode.Additive).Task;
	}
}

