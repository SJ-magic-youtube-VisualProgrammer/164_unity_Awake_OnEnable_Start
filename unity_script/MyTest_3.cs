/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class MyTest_3 : MonoBehaviour
{
	/****************************************
	****************************************/
	int c_update = 0;
	
	/******************************
	******************************/
	MyTest_3(){
		// Debug.Log("MyTest_3 : ctr");
	}
	
	/******************************
	******************************/
    void Awake()
    {
        Debug.Log("MyTest_3 : Awake ( frameCount = " + Time.frameCount + " )");
    }
	
	/******************************
	******************************/
    void OnEnable()
    {
        Debug.Log("MyTest_3 : OnEnable ( frameCount = " + Time.frameCount + " )" );
    }
	
	/******************************
	******************************/
    void Start()
    {
        Debug.Log("MyTest_3 : Start ( frameCount = " + Time.frameCount + " )");
    }
	
	/******************************
	******************************/
    void Update()
    {
		if( c_update < 2 ){
			// c_update++;
			
			Debug.Log("MyTest_3 : Update ( frameCount = " + Time.frameCount + " )");
		}
		
        SjTest();
    }
	
	/******************************
	******************************/
    void LateUpdate()
    {
		if( c_update < 2 ){
			c_update++;
			
			Debug.Log("MyTest_3 : LateUpdate ( frameCount = " + Time.frameCount + " )");
		}
    }
	
	/******************************
	******************************/
    void OnDisable()
    {
        Debug.Log("MyTest_3 : OnDisable");
    }
	
	/******************************
	******************************/
    void OnApplicationQuit()
    {
        Debug.Log("MyTest_3 : OnApplicationQuit");
    }
	
	/******************************
	******************************/
    void OnDestroy()
    {
        Debug.Log("MyTest_3 : OnDestroy");
    }
	
	/******************************
	******************************/
    void SjTest(){
		// System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
		// sw.Start();
		
		UnityEngine.Profiling.Profiler.BeginSample("this is sj test");
		
		// for (int i = 0; i < 1E+7; i++)
		for (int i = 0; i < 1E+5; i++)
		{
			/********************
			component 有
			********************/
			Transform t = gameObject.GetComponent<Transform>();
			// gameObject.TryGetComponent<Transform>(out Transform t);
			// Transform t = gameObject.transform;
			
			// Transform t = GetComponent<Transform>();
			// TryGetComponent<Transform>(out Transform t);
			// Transform t = transform;
			
			/********************
			component 無
			********************/
			// Collider t = gameObject.GetComponent<Collider>();
			// gameObject.TryGetComponent<Collider>(out Collider t);
			
			// Collider t = GetComponent<Collider>();
			// if( TryGetComponent<Collider>(out Collider t);
		}
		
		UnityEngine.Profiling.Profiler.EndSample();
		
		// sw.Stop();
		// UnityEngine.Debug.Log(sw.Elapsed);
	}
	
	/******************************
	******************************/
	public void Func(){
		Debug.Log("MyTest_3::Func()");
	}
}
