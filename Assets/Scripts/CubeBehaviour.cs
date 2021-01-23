using UnityEngine;
using Zenject;

public class CubeBehaviour : MonoBehaviour
{
    [Inject]
    private IPort _instance;

    // Start is called before the first frame update
    void Start()
    {
        _instance.Handle();
    }
}
