/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetNonActive_OnAwake : MonoBehaviour
{
	/****************************************
	****************************************/
	
	/******************************
	******************************/
    void Awake()
    {
        Debug.Log("SetNonActive_OnAwake : Awake ( frameCount = " + Time.frameCount + " )");
		
		Debug.Log("SetNonActive_OnAwake : 非アクティブ前");
		gameObject.SetActive(false);
		Debug.Log("SetNonActive_OnAwake : 非アクティブ後");
    }
	
	/******************************
	******************************/
    void OnEnable()
    {
        Debug.Log("SetNonActive_OnAwake : OnEnable ( frameCount = " + Time.frameCount + " )" );
    }
	
	/******************************
	******************************/
    void Start()
    {
        Debug.Log("SetNonActive_OnAwake : Start ( frameCount = " + Time.frameCount + " )");
    }
	
	/******************************
	******************************/
    void Update()
    {
        
    }
	
	/******************************
	******************************/
    void LateUpdate()
    {
        
    }
	
	/******************************
	******************************/
    void OnDisable()
    {
        Debug.Log("SetNonActive_OnAwake : OnDisable");
    }
	
	/******************************
	******************************/
    void OnApplicationQuit()
    {
        Debug.Log("SetNonActive_OnAwake : OnApplicationQuit");
    }
	
	/******************************
	******************************/
    void OnDestroy()
    {
        Debug.Log("SetNonActive_OnAwake : OnDestroy");
    }
}
