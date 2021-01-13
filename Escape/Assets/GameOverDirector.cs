using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverDirector : MonoBehaviour{
  GameObject score;

    // Start is called before the first frame update
    void Start(){
      this.score = GameObject.Find("score");
      float resultScore = PlayerPrefs.GetFloat("SCORE");
      this.score.GetComponent<Text>().text = resultScore.ToString("F2")+"秒";
    }

    // Update is called once per frame
    void Update(){
      if(Input.GetMouseButtonDown(0)){
        SceneManager.LoadScene("GameScene");
      }
    }
}
