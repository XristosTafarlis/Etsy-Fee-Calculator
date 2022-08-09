using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour{
	[SerializeField] float inputText;
	[SerializeField] GameObject inputField;
	[SerializeField] GameObject textDisplay;

	void Update(){
		inputText = float.Parse(inputField.GetComponent<Text>().text);
		textDisplay.GetComponent<Text>().text = ((1.14969 * inputText) - 0.140262).ToString();
	}
}