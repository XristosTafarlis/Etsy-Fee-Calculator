using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour{
	[SerializeField] GameObject inputField;
	[SerializeField] GameObject textDisplay;
	
	int temp;

	void Update(){
		int number;
		bool sucsess = int.TryParse(inputField.GetComponent<Text>().text, out number);
		
		if(sucsess){
			temp = number;
		}
		
		if(temp > 0){
			textDisplay.GetComponent<Text>().text = ((1.58781 * temp) + 47.4405).ToString("F2");
		}else{
			textDisplay.GetComponent<Text>().text = "NaN";
		}
	}
}