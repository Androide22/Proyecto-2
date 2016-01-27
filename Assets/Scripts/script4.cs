using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class script4 : MonoBehaviour {
	
	public Animation uny;

	void Awake(){
		uny = GameObject.Find ("sprunity"). GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void Ani1(){
		
		uny ["Animacion1"].enabled = true;
		uny.Play ("Animacion1");
	}
	public void Ani2(){

		uny ["Animacion2"].enabled = true;
		uny.Play ("Animacion2");
	}
	public void Ani3(){

		uny ["Animacion3"].enabled = true;
		uny.Play ("Animacion3");
	}
	public void PantallaCero(string nombrePantalla) {
		SceneManager.LoadScene ("escena1");		
	}

}
