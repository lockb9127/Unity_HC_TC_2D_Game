using UnityEngine;

public class TetrisManager : MonoBehaviour
{
    [Header("掉落時間"), Range(0.1f, 10)]
    public float timeFall = 1.55f;
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
    public Transform traCanvas;
    
    

    public RectTransform currentTetris;

    public int indexNext;
    private void start()
    {
        RandomTetris();
    }

    public float timer;
    private void controlTertis()
    {
        
        
            timer += Time.deltaTime;

         
    }

    

    private void generate()
    {

    }
    public void RandomTetris()
    {
        indexNext = Random.Range(0, 5);
        traNextAree.GetChild(indexNext).gameObject.SetActive(true);
    }
    public void StrtGame()
    {
       GameObject tetris= traNextAree.GetChild(indexNext).gameObject;
        Instantiate(tetris);
        GameObject current = Instantiate(tetris, traCanvas);
        current.GetComponent<RectTransform>().anchoredPosition = new Vector2(40, 400);
        tetris.SetActive(false);
        RandomTetris();
    }
    public void SetGround()
    {
        int count = currentTetris.childCount;

        for (int r= 0; 1 < count; r++)
        {
            currentTetris.GetChild(1).name = "地板";
            currentTetris.GetChild(1).gameObject.layer = 9;
        }
        

        
    }
    //     {
    //              timer = 0;
    //currentTetris.anchoredPosition -= new Vector2(0, 50);
    [Header("分數判定區域")]
    public Transform traScoreArea;

   

    private void Start()
    {
        SpwnTetris();
    }
    
    private void SpwnTetris()
    {
        indexNext = Random.Range(0, 5);
        traNextAree.GetChild(indexNext).gameObject.SetActive(true);
    }
    private void Update()
    {
        controlTertis();
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
