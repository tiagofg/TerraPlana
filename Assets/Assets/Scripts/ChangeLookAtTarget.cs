using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

    void Start() {
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {

        // change the target of the LookAtTarget script to be this gameobject.		
        desativarTodos();
        GameObject.Find(this.name).GetComponent<AudioSource>().enabled = true;
        //Camera.main.fieldOfView = 60 * target.transform.localScale.x;
    }

    void desativarTodos()
    {
        GameObject[] vetPlanetas = GameObject.FindGameObjectsWithTag("tudo");

        for (int i = 0; i < vetPlanetas.Length; i++)
        {
            Debug.Log(vetPlanetas[i].name + " parar");
            vetPlanetas[i].GetComponent<AudioSource>().enabled = false;
        }
    }
}
