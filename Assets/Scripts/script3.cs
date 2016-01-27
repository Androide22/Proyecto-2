using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class script3 : MonoBehaviour {
	public Text pr;

	void Start () {
		pr = GameObject.Find ("txtUsuario").GetComponent<Text> ();
	}

	public void Cambio(string arg0)
	{
		pr.text = arg0;
	}
	public void PantallaCero(string nombrePantalla) {
		SceneManager.LoadScene ("escena1");		
	}
}
