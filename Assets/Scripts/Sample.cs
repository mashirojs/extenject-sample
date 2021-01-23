using UnityEngine;

public class Sample : IPort
{
    public void Handle()
    {
        Debug.Log("sample message.");
    }
}
