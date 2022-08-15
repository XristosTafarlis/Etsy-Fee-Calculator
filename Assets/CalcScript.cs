using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour{
	[SerializeField] GameObject inputField;
	[SerializeField] GameObject textDisplay;

	void Update(){
		textDisplay.GetComponent<Text>().text = ((1.58781 * int.Parse(inputField.GetComponent<Text>().text)) + 47.4405).ToString("F2");
	}
}