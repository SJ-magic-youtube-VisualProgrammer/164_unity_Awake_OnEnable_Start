/************************************************************
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class MyInstantiate : MonoBehaviour
{
	/****************************************
	****************************************/
     [SerializeField] GameObject obj;
	 MyTest_1 my_test_1;
 
	/****************************************
	****************************************/
	
	/******************************
	******************************/
     private void Awake()
	 {
		// 別scriptのAwake()関数からInstantiateした場合
		Debug.Log("<color=red>インスタンシエイト前</color>");
		GameObject g = Instantiate(obj);
		g.SetActive(true);
		// my_test_1 = g.GetComponent<MyTest_1>();
		Debug.Log("<color=green>インスタンシエイト後</color>");
		
		/*
		// 別scriptのAwake()関数からInstantiateし、その場でactive/ 非active、としたら
		Debug.Log("<color=red>インスタンシエイト前</color>");
		GameObject g = Instantiate(obj);
		
		Debug.Log("<color=yellow>アクティブ</color>");
		g.SetActive(true);
		
		Debug.Log("<color=yellow>非アクティブ</color>");
		g.SetActive(false);
		
		Debug.Log("<color=green>インスタンシエイト後</color>");
		*/
     }
	 
	/******************************
	******************************/
    void Start()
    {
		/*
		Debug.Log("MyInstantiate : before Instantiate ( frameCount = " + Time.frameCount + " )");
		GameObject g = Instantiate(obj);
		Debug.Log("MyInstantiate : after  Instantiate ( frameCount = " + Time.frameCount + " )");
		*/
    }
	
	/******************************
	******************************/
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.A) ){
			// my_test_1.Func();
		}else if( Input.GetKeyDown(KeyCode.B) ){
			Debug.Log("MyInstantiate : before Instantiate ( frameCount = " + Time.frameCount + " )");
			GameObject g = Instantiate(obj);
			g.SetActive(true);
			Debug.Log("MyInstantiate : after  Instantiate ( frameCount = " + Time.frameCount + " )");
		}
    }
}
