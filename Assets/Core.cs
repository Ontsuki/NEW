using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Core : MonoBehaviour {
    public int row;
    public int col;
    public int[,] grid= new int[5,6];
    public int bomb;
    public Sprite[] icon;
    public GameObject text1;
    public GameObject text2;


    // Use this for initialization
    void Start () {
        /*
        for (int a = 0; a < 5; a++)
        {
            for (int b = 0; b < 6; b++)
            {
                row = a;
                col = b;
                grid[row, col] = Random.Range(0, 3);

            }
        }
        */
        bomb = Random.Range(0, 4);
        //row = Random.Range(0, 5);
        //col = Random.Range(0, 6);
        // int[,] grid = new int[row, col];
        //bomb = Random.value < 0.01f;
        /*
        if (row < 6 && col < 7)
        {
            grid[row, col] = Random.Range(0, 3);
            Debug.Log("a" + row);
            Debug.Log("b" + col);
            Debug.Log("c" + bomb);
        }*/

        
    }

    private void OnMouseDown()
    {
        if(bomb == 1)//新
        {
            GetComponent<SpriteRenderer>().sprite = icon[1];
            WhoWin(1);
        }
        else if (bomb == 2)//色1
        {
            GetComponent<SpriteRenderer>().sprite = icon[2];
            Boring(1);
        }
        else if (bomb == 3)//色2
        {
            GetComponent<SpriteRenderer>().sprite = icon[3];
            Boring(2);
        }
        else if(bomb == 0)//哭
        {
            GetComponent<SpriteRenderer>().sprite = icon[0];
            WhoWin(2);
        }
    }

    void WhoWin(int cases)
    {
        if(cases == 1)
        {
            text1.GetComponent<TextMesh>().text = "YOU HAD WON A NICE FEELING";
            //text1.SetActive(true);
        }
        else if(cases == 2)
        {
            text1.GetComponent<TextMesh>().text = "WELL, YOU CAN STILL HAVE A GOOD DAY";
        }
    }

    void Boring(int cases)
    {
        if (cases == 1)
        {
            text2.GetComponent<TextMesh>().text = "NICE TRY";
        }
        else if (cases == 2)
        {
            text2.GetComponent<TextMesh>().text = "UNH, THAT'S A GOOD COLOR";
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
