using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{
    bool rpush = false;
    bool lpush = false;

    // Start is called before the first frame update
    void Start(){
    }

    // Update is called once per frame
    public void RightPushDown(){
      rpush = true;
    }
    public void RightPushUp(){
      rpush = false;
    }
    public void LeftPushDown(){
      lpush = true;
    }
    public void LeftPushUp(){
      lpush = false;
    }
    void Update(){
      if(rpush){
        transform.Translate(0.1f,0,0);
      }else if(lpush){
        transform.Translate(-0.1f,0,0);
      }
    }
}
