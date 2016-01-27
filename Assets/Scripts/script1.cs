using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class script1 : MonoBehaviour {

	public void PantallaUno(string nombrePantalla) {
		SceneManager.LoadScene ("escena2");		
	}
	public void PantallaDos(string nombrePantalla) {
		SceneManager.LoadScene ("escena3");		
	}
	public void PantallaTres(string nombrePantalla) {
		SceneManager.LoadScene ("escena4");		
	}
	public void SalirApp() {
		Application.Quit ();
	}
}
