using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

	public void OnClick(int scene){
		SceneManager.LoadScene (scene);
	}

}
