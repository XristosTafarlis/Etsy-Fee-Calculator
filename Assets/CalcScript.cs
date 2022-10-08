using UnityEngine;
using UnityEngine.UI;


public class CalcScript : MonoBehaviour{
	[SerializeField] Text inputField;
	[SerializeField] Text textDisplay;
	[SerializeField] Dropdown transportPriceSelector;
	
	int number;
	
	void Update(){
		bool sucsess = int.TryParse(inputField.text, out number);
		
		if(sucsess){
			textDisplay.text = (transportPriceSelector.value == 0)? ((1.58781 * number) + 32.4405).ToString("F2") : ((1.58781 * number) + 47.4405).ToString("F2");
		}
		
		if( string.IsNullOrEmpty(inputField.text)){
			textDisplay.text = "NaN";
		}
	}
}