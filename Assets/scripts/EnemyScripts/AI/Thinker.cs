using UnityEngine;

public class Thinker : MonoBehaviour
{
    public Brain brain;

    void Update()
    {
        brain.Think(this);
    }
}
