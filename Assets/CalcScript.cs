using UnityEngine;
using UnityEngine.UI;

public class CalcScript : MonoBehaviour{
	[SerializeField] Text inputField;
	[SerializeField] Text textDisplay;
	[SerializeField] Slider transportSlider;
	[SerializeField] Text transportSliderText;
	[SerializeField] Toggle freeShippingToggle;
	[SerializeField] AudioSource hover;
	
	int number;
	bool freeShipping;
	
	void Update(){
		bool sucsess = int.TryParse(inputField.text, out number);
		
		if(sucsess){
			if(freeShippingToggle.isOn)
				textDisplay.text = (1.47016 * (number + transportSlider.value) + 0.558659).ToString("F2");
			else
				textDisplay.text = (1.47016 * number + 0.558659 + transportSlider.value).ToString("F2");
		}
		
		//Source : https://www.wolframalpha.com/input?i2d=true&i=x-0.2-%5C%2840%29x*Divide%5B4%2C100%5D%2B0.3%5C%2841%29-%5C%2840%29x*Divide%5B65%2C1000%5D%5C%2841%29-Divide%5B24%2C100%5D*+%5C%2840%29x-0.2-%5C%2840%29x*Divide%5B4%2C100%5D%2B0.3%5C%2841%29-%5C%2840%29x*Divide%5B65%2C1000%5D%5C%2841%29%5C%2841%29%3Dk
		
		if(string.IsNullOrEmpty(inputField.text)){
			textDisplay.text = "NaN";
		}
	}
	
	public void onChange(){
		transportSliderText.text = "Transport : " + transportSlider.value + " €";
		//if(!hover.isPlaying){
			hover.Play();
		//}
	}
}