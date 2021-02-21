using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;

public class Scoring : MonoBehaviour
{
	public float time;
    // Update is called once per frame
	public Text score;
	public Text slotNum1;
	public Text slotNum2;
	public Text slotNum3;
	public Text slotNum4;
	public Text slotNum5;
	public Text slotNum6;

	void Update(){
	int temp1 = (Convert.ToInt32(slotNum1.text) + Convert.ToInt32(slotNum2.text) + Convert.ToInt32(slotNum3.text) + Convert.ToInt32(slotNum4.text) + Convert.ToInt32(slotNum5.text)+ Convert.ToInt32(slotNum6.text)) * 100 / 54 ;
	score.text = "Score: " + temp1.ToString("") + "%"; }
	
}
