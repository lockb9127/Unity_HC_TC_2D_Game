using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("這是汽車"), Range(0, 150)]
    public int cat = 100;
    private void Start()
    {
        print("你好");
        print(cat);

    }


}
