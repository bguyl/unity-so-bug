using UnityEngine;

public class Singleton : MonoBehaviour
{
    protected static GameObject _instance;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = gameObject;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
