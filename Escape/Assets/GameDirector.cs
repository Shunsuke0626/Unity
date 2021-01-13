using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour{
  GameObject hpGauge;
  GameObject timer;
  float hp = 1;
  float count = 0;
    // Start is called before the first frame update
    void Start(){
      this.timer = GameObject.Find("timer");
      this.hpGauge = GameObject.Find("hpGauge");
    }
    public void DecreaseHp(){
      this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
      hp -= 0.1f;
    }

    // Update is called once per frame
    void Update(){
      this.count += Time.deltaTime;
      this.timer.GetComponent<Text>().text = count.ToString("F2") + "秒";
      if(this.hp <= 0){
        PlayerPrefs.SetFloat("SCORE", this.count);
        PlayerPrefs.Save();
        SceneManager.LoadScene("GameOverScene");
      }
    }
}
