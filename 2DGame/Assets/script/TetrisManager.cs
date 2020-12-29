using UnityEngine;

public class TetrisManager : MonoBehaviour
{
    [Header("掉落時間"), Range(0.1f, 10)]
    public float time = 1.55f;
    [Header("目前分數")]
    public int score = 1;
    [Header("最高分數")]
    public int scoreA = 99;
    [Header("等級")]
    public int Lv = 1;
    [Header("存放物件")]
    public GameObject Object;
    [Header("掉落音效")]
    public AudioClip down;
    [Header("選轉音效")]
    public AudioClip SpriteB;
    [Header("消除音效")]
    public AudioClip SpriteC;
    [Header("遊戲結束音效")]
    public AudioClip SpriteD;
    [Header("下一個俄羅斯方塊區域")]
    public Transform traNextAree;
    [Header("畫布")]
    public Transform Canvas;
    

    public RectTransform currentTetris;

    public int indexNext;
    private void start()
    {
        RandomTetris();
    }

    public float timer;
    private void controlTertis()
    {
        time += Time.deltaTime;
    }
    private void generate()
    {

    }
    public void RandomTetris()
    {
        indexNext = Random.Range(0, 5);
        traNextAree.GetChild(indexNext).gameObject.SetActive(true);
    }

    //     {
    //              timer = 0;
    //currentTetris.anchoredPosition -= new Vector2(0, 50);

    private void Start()
    {
        SpwnTetris();
    }
    
    private void SpwnTetris()
    {
        indexNext = Random.Range(0, 5);
        traNextAree.GetChild(indexNext).gameObject.SetActive(true);
    }
    public void starGame()
     {

        }
    private void score01()
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
