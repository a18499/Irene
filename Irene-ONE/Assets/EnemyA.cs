using UnityEngine;
using System.Collections;

public class EnemyA : MonoBehaviour {
    public GameObject explo; //宣告一個名為explo的物件
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position += new Vector3(0, -0.01f, 0);
    }
    void OnTriggerEnter2D(Collider2D col) //名為col的觸發事件
    {
        if (col.tag == "Jet" || col.tag == "Bullet") //如果碰撞的標籤是Ship或Bullet
        {
            
            Instantiate(explo, gameObject.transform.position, gameObject.transform.rotation); //在外星人的位置產生爆炸
            Destroy(col.gameObject); //消滅碰撞的物件
            Destroy(gameObject); //消滅物件本身
            if (col.tag == "Jet") //如果碰撞的標籤是Ship
            {
                Instantiate(explo, col.gameObject.transform.position, col.gameObject.transform.rotation);

                //在碰撞物件的位置產生爆炸，也就是在太空船的位置產生爆炸
                GameFunction.Instance.GameOver();
            }
            GameFunction.Instance.AddScore();
        }
    }
}
