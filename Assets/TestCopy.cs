using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCopy : MonoBehaviour {
	public Button btn;
	public InputField input;
	public Text text;
	// Use this for initialization
	void Start () {
		btn.onClick.AddListener (CheckText);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void  CheckText()
	{
		TextEditor te = new TextEditor ();
		if (input.text != "") {
			Debug.Log ("input 是有值的");
			te.text = input.text;
			te.SelectAll ();
			te.Copy ();
		} else {
			Debug.Log ("没有复制成功");
		}
	}

}
