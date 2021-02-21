using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartRand : MonoBehaviour
{
	char[] numbers = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
	public Text slotNum;
	public float time;
	
    // Update is called once per frame
    void Update()
    {
        slotNum.text = numbers[Random.Range(0, numbers.Length)].ToString();
	
    }
	void DelayNum(){ enabled=false; }
	public void OnEnable() { enabled = true; }
	public void OffEnable(){
		//enabled = false;
		Invoke("DelayNum", time);
	}

}
