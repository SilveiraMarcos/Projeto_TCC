using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArduinoBluetoothAPI;
using System;


public class BtComunic : MonoBehaviour {


	string message;
	private BluetoothHelper BTHelper;

	private string x;
	//public Text text; 

	public static bool verificLuz = false;

	String deviceName = "";

	void Start () {
		deviceName = "HC-06"; //bluetooth should be turned ON;
		try{
			x="";
			BTHelper = BluetoothHelper.GetInstance(deviceName);
			BTHelper.setLengthBasedStream();
			BTHelper.OnConnected += OnBluetoothConnected; //OnBluetoothConnected is a function defined later on

		}catch(Exception ex){
			Debug.Log(ex);
			x = ex.ToString();
		}
	}
	void Update(){


			if (verificLuz == true) {
				Ligar_bt();
				verificLuz = false;
			}
	}

	void OnBluetoothConnected()
	{
		try{
			BTHelper.StartListening();
			//StartCoroutine(blinkLED());

		}catch (Exception ex){
			x += ex.ToString();
			Debug.Log(ex.Message);
		}

	}

	public void connect_bt(){
		if (!BTHelper.isConnected ()) {
			if(BTHelper.isDeviceFound())
				BTHelper.Connect (); // tries to connect
		}
	} 
	public void desconnect_bt(){
		if (BTHelper.isConnected ()) {
		BTHelper.StopListening ();
		}
	}
	public void Ligar_bt(){

		if (BTHelper.isConnected ()) {
			try {
				BTHelper.SendData (Turn_ON());
			} catch (Exception e) {
				x += e.Message;
				Debug.Log(e.Message);
			}
		}
	}

	void OnDestroy(){
		if(BTHelper!=null)
			BTHelper.StopListening();
	}

	private byte[] Turn_ON(){ 

		byte[] turn_on = new byte[]{(byte)'E' /*E stands for enable */, 2};
		x += BTHelper.isConnected().ToString();


		for (byte i = 2; i < 8; i++) {
			turn_on [1] = i;
		}

		return turn_on;
	}
	void Turn_Off(){
		//Text.GetComponent<Text>().text = "Desligado !";
		Debug.Log("Desligado !");
	}

}
