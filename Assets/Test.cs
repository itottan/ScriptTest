using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //課題 配列を宣言して出力
        int[] arr = { 1, 2, 3, 4, 5 };

        PrintArray(arr);

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int n = arr[i];
            arr[i] = arr[arr.Length - i - 1];
            arr[arr.Length - i - 1] = n;
        }

        PrintArray(arr);

        //発展課題
        Boss taskBoss = new Boss();
        for(int i = 0; i<= 10;i++)
        {
            taskBoss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //配列出力の関数
    /*
    *こちらは質問となります：
    *この関数の記入場所と、修飾子などの使い方は問題ないでしょうか？
    */
    void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
    }
}

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53; //魔力


    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃の関数
    public void Magic ()
    {
        if (this.mp >= 5)
        {
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}