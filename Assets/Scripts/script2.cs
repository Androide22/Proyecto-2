using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class script2 : MonoBehaviour {
	public float Velocidad = 5.0F;
	private bool arriba = false;
	private bool abajo = false;
	private bool izquierda = false;
	private bool derecha = false;
	public GameObject spr1;
	public void Awake(){
		spr1 = GameObject.Find ("sprunity");

	}

	// Use this for initialization
	void Start () {}

	void Update () {
		if (arriba) {
			spr1.transform.Translate(Vector2.up * Time.maximumDeltaTime * Velocidad);
		}

		if (abajo) {
			spr1.transform.Translate(Vector2.down * Time.maximumDeltaTime * Velocidad);
		}
		if (izquierda) {
			spr1.transform.Translate(Vector2.left * Time.maximumDeltaTime * Velocidad);
		}
		if(derecha) {
			spr1.transform.Translate (Vector2.right * Time.maximumDeltaTime * Velocidad);
		}
	}
	public void MoverDerecha()
	{
		derecha = true;
	}

	public void MoverIzquierda()
	{
		izquierda = true;
	}

	public void MoverArriba()
	{
		arriba = true;
	}

	public void MoverAbajo()
	{
		abajo = true;
	}

	public void Detener()
	{
		derecha = false;
		izquierda = false;
		arriba = false;
		abajo = false;
	}
	public void PantallaCero(string nombrePantalla) {
		SceneManager.LoadScene ("escena1");		
	}
}
