/************************************************************
■Unity：Script（スクリプト）を追加する４つの方法
	https://www.fast-system.jp/unity%EF%BC%9Ascript%EF%BC%88%E3%82%B9%E3%82%AF%E3%83%AA%E3%83%97%E3%83%88%EF%BC%89%E3%82%92%E8%BF%BD%E5%8A%A0%E3%81%99%E3%82%8B%EF%BC%94%E3%81%A4%E3%81%AE%E6%96%B9%E6%B3%95/

■【初心者Unity】スクリプトからコンポーネントを追加する方法
	https://tech.pjin.jp/blog/2022/10/31/addcomponent_and_requirecomponent
************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/************************************************************
************************************************************/
public class MyAddComponent : MonoBehaviour
{
	/****************************************
	****************************************/
	
	/****************************************
	****************************************/
	
	/******************************
	******************************/
    void Awake()
    {
		/*
		Debug.Log("<color=red>before add</color>");
		MyTest_1 my_test_1 = gameObject.AddComponent<MyTest_1>();
		// my_test_1.enabled = false;
		Debug.Log("<color=red>after add</color>");
		*/
    }
	
	/******************************
	******************************/
    void Start()
    {
        
    }
	
	/******************************
	******************************/
    void Update()
    {
		if( Input.GetKeyDown(KeyCode.C) ){
			Debug.Log("<color=red>before add</color>");
			MyTest_1 my_test_1 = gameObject.AddComponent<MyTest_1>();
			// my_test_1.enabled = false;
			Debug.Log("<color=red>after add</color>");
		}
    }
}
