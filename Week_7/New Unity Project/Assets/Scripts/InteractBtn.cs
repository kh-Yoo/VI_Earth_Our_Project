using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractBtn : MonoBehaviour
{
    //플레이어 게임오브젝트
    public GameObject player;
    //상호작용 게임오브젝트의 갯수
    public const int numCoins = 3;
    public const int numHearts = 3;
    //상호작용 게임오브젝트 배열 생성
    public GameObject[] coins = new GameObject[numCoins];
    public GameObject[] hearts = new GameObject[numHearts];
    //플레이어의 position 객체 생성
    Vector3 posPlayer;
    //상호작용 position 배열 생성
    Vector3[] posCoins = new Vector3[numCoins];
    Vector3[] posHearts = new Vector3[numHearts];
    //플레이어와 상호작용 오브젝트 사이의 거리 배열
    private float[] btwCoins = new float[numCoins];
    private float[] btwHearts = new float[numHearts];

    Renderer objectColor;

    // Start is called before the first frame update
    void Start()
    {
        showDistance();
    }

    // Update is called once per frame
    void Update()
    {
        posPlayer = player.gameObject.transform.position;

        for (int i = 0; i < coins.Length; i++)
        {
            float distance = calcDistance(posPlayer, posCoins[i]);
            if (distance > 4.0)
            {
                SpriteOutline objectBorder = coins[i].GetComponent<SpriteOutline>();
                objectColor = coins[i].gameObject.GetComponent<Renderer>();
                objectColor.material.color = Color.white;
                objectBorder.enabled = false;
            }
            else if (distance <= 4.0 && distance > 2.0)
            {
                SpriteOutline objectBorder = coins[i].GetComponent<SpriteOutline>();
                objectColor = coins[i].gameObject.GetComponent<Renderer>();
                objectColor.material.color = Color.white;
                objectBorder.enabled = true;
            }
            else
            {
                SpriteOutline objectBorder = coins[i].GetComponent<SpriteOutline>();
                objectColor = coins[i].gameObject.GetComponent<Renderer>();
                objectColor.material.color = new Color(255,255,0);
                objectBorder.enabled = true;
            }
        }
        for (int i = 0; i < hearts.Length; i++)
        {
            float distance = calcDistance(posPlayer, posHearts[i]);
            if (distance > 4.0)
            {
                SpriteOutline objectBorder = hearts[i].GetComponent<SpriteOutline>();
                objectColor = hearts[i].gameObject.GetComponent<Renderer>();
                objectColor.material.color = Color.white;
                objectBorder.enabled = false;
            }
            else if (distance <= 4.0 && distance > 2.0)
            {
                SpriteOutline objectBorder = hearts[i].GetComponent<SpriteOutline>();
                objectColor = hearts[i].gameObject.GetComponent<Renderer>();
                objectColor.material.color = Color.white;
                objectBorder.enabled = true;
            }
            else
            {
                SpriteOutline objectBorder = hearts[i].GetComponent<SpriteOutline>();
                objectColor = hearts[i].gameObject.GetComponent<Renderer>();
                objectColor.material.color = new Color(255, 255, 0);
                objectBorder.enabled = true;
            }
        }
    }

    public float calcDistance(Vector3 posPlayer, Vector3 posObject)
    {
        float btwX = (posPlayer.x - posObject.x) * (posPlayer.x - posObject.x);
        float btwY = (posPlayer.y - posObject.y) * (posPlayer.y - posObject.y);
        float distance = Mathf.Sqrt(btwX + btwY);
        return distance;
    }

    public void showDistance()
    {
        posPlayer = player.gameObject.transform.position;

        for (int i = 0; i < numCoins; i++)
        {
            posCoins[i] = coins[i].gameObject.transform.position;
            btwCoins[i] = calcDistance(posPlayer, posCoins[i]);
            //Debug.Log("Coin " + i + " 과의 거리는 " + btwCoins[i] + " 입니다.");
        }
        for (int i = 0; i < numHearts; i++)
        {
            posHearts[i] = hearts[i].gameObject.transform.position;
            btwHearts[i] = calcDistance(posPlayer, posHearts[i]);
            //Debug.Log("Heart " + i + " 과의 거리는 " + btwHearts[i] + " 입니다.");
        }
    }
}