using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour{
    public GameObject enemyPrefab;
    float span1 = 0.3f;
    float span2 = 0.2f;
    float delta1 = 0;
    float delta2 = 0;
    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    void Update(){
      this.delta1 += Time.deltaTime;
      this.delta2 += Time.deltaTime;
      if(this.delta1 > this.span1){
        this.delta1 = 0;
        GameObject go = Instantiate(enemyPrefab) as GameObject;
        int px = Random.Range(-10,10);
        go.transform.position = new Vector3(px,7,0);
      }
      if(this.delta2 > this.span2){
        this.delta2 = 0;
        GameObject go = Instantiate(enemyPrefab) as GameObject;
        int px = Random.Range(-10,10);
        go.transform.position = new Vector3(px,7,0);
      }
    }
}
