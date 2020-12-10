using UnityEngine;

public class TetrisManager : MonoBehaviour
{
    [Header("掉落時間"), Range(0.1f, 10)]
    public float time = 1.55f;
    [Header("目前分數")]
    public int score = 1;
    [Header("最高分數")]
    public int scoreA = 1;
    [Header("等級")]
    public int Lv = 1;
    [Header("存放物件")]
    public GameObject Object;
    [Header("掉落音效")]
    public AudioClip SpriteA;
    [Header("選轉音效")]
    public AudioClip SpriteB;
    [Header("消除音效")]
    public AudioClip SpriteC;
    [Header("遊戲結束音效")]
    public AudioClip SpriteD;
    
    private void generate()
    {

    }

    public void score(int Score)
    {

    }

    private void gametime()
    {

    }

    private void gameover()
    {

    }

    public void restart()
    {

    }

    public void leave()
    {

    }


}
