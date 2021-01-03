using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour{
  float rotSpeed = 0;
  bool flag = false;
    // Start is called before the first frame update
  void Start(){

  }

    // Update is called once per frame
  void Update(){
    if(Input.GetMouseButtonDown(0)){
      if(flag == false){
        flag = true;
      }else if (flag == true){
        flag = false;
      }
    }
    if(flag == true && this.rotSpeed <= 0.01f){
      this.rotSpeed = 20;
    } else if (flag == false){
      this.rotSpeed *= 0.98f;
    }
    transform.Rotate(0,0,this.rotSpeed);
  }
}
