using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocity;
    public float rotation_velocity;
    Vector2 transformacion;
    Camera mCam;
    public Transform customPivot;
    void Start(){
        transformacion.x=0;
        transformacion.y=0;   
        mCam=Camera.main;
        mCam.transform.Translate(0,0,0);
    }

    // Update is called once per frame
    void Update(){

        //transform.Rotate(0,Time.deltaTime*velocity,0);
        //transform.Translate(Time.deltaTime,0,0);
        if (Input.GetKeyDown(KeyCode.UpArrow))
            transformacion.x=1;
        if (Input.GetKeyDown(KeyCode.DownArrow))
            transformacion.x=-1;
        if (Input.GetKeyDown(KeyCode.LeftArrow)) 
            transformacion.y=-1;
        if (Input.GetKeyDown(KeyCode.RightArrow)) 
            transformacion.y=1;
        if (Input.GetKeyUp(KeyCode.UpArrow))
            transformacion.x=0;
        if (Input.GetKeyUp(KeyCode.DownArrow))
            transformacion.x=0;
        if (Input.GetKeyUp(KeyCode.LeftArrow)) 
            transformacion.y=0;
        if (Input.GetKeyUp(KeyCode.RightArrow)) 
            transformacion.y=0;
        trans(transformacion);
    }
    void trans(Vector2 directions){
        transform.Translate(0,0,directions.x*velocity*Time.deltaTime);
        transform.RotateAround(customPivot.position,Vector3.up,directions.y*rotation_velocity*Time.deltaTime);
        //transform.Rotate(0,*velocity,0);
    }
}
