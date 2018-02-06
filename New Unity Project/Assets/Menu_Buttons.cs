using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Buttons : MonoBehaviour {

	// game objects needed
	public GameObject MenuPanel;
	public GameObject StartPanel;
	public GameObject QuitPanel;

	// initialization
	void Start () {
		MenuPanel.SetActive (true);
		StartPanel.SetActive (false);
		QuitPanel.SetActive (false);
	}

	// public functions for activation of panels
	public void ShowMenuPanel()
	{
		MenuPanel.SetActive (true);
		StartPanel.SetActive (false);
		QuitPanel.SetActive (false);
	}

	public void ShowStartPanel()
	{
		MenuPanel.SetActive (false);
		StartPanel.SetActive (true);
		QuitPanel.SetActive (false);
	}

	public void ShowQuitPanel()
	{
		MenuPanel.SetActive (false);
		StartPanel.SetActive (false);
		QuitPanel.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
