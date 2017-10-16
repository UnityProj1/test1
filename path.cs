using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;
public class path : MonoBehaviour {
	public GameObject go;
	void Start()
	{
		iTween.MoveTo (this.gameObject, iTween.Hash 
		               ("speed",0.8f, "path", iTweenPath.GetPath ("New Path 1"), 
		                "orienttopath",true ,"easetype", iTween.EaseType.linear,"oncomplete","endyulan"));
	}
//	sdascdasdas
}

//djsfnjksnppp