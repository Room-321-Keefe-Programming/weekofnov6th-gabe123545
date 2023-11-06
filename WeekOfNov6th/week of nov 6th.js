function ConvertTemp() {
	var output = document.getElementById("outputBox")
	var input = document.getElementById("inputBox")
	var Radio = document.getElementById("radio1")
	var Radio = document.getElementById("radio2")
	
	 if (Radio.checked)
	 {
		output.innerHTML += (parseFloat(input.value) - 32) * 5 / 9 + " Degrees celsious";
	 }
	  else if (Radio2.checked)
	 {
		output.innerHTML += (parseFloat(input.value) * 9 / 5) + 32 + "Degrees Fahrenheit" + "<br>";
	 }
}
function ConvertMoney() {
	var selectedOption = document.getElementById("money").value;
	var input2 = document.getElementById("inputBox2");
	var rtbOutput = document.getElementById("outputBox");

	if (selectedOption == "Dollar to Yen") {
		rtbOutput.innerText += (parseFloat(input2.value) * 149.81) + " Yen\n";
	} else if (selectedOption == "Yen to Dollar") {
		rtbOutput.innerText += (parseFloat(input2.value) * 0.0067) + " Dollars\n";
	} else if (selectedOption == "Dollar to Reais") {
		rtbOutput.innerText += (parseFloat(input2.value) * 4.91) + " Reais\n";
	} else if (selectedOption == "Reais to Dollar") {
		rtbOutput.innerText += (parseFloat(input2.value) * 0.20) + " Dollars\n";
	} else if (selectedOption == "Rupees to Dollar") {
		rtbOutput.innerText += (parseFloat(input2.value) * 0.012) + " Dollars\n";
	} else if (selectedOption == "Dollar to Rupees") {
		rtbOutput.innerText += (parseFloat(input2.value) * 83.22) + " Rupees\n";
	}
}
function Direction1() {
	var input2 = document.getElementById("inputBox2").value;
	var rtbOutput = document.getElementById("outputBox");
	
	if (input2 === "") {
		rtbOutput.innerText += "Type something\n";
	}

	if (document.getElementById("chkMilesToKilometers").checked){
		rtbOutput.innerText += (parseFloat(input2) * 1.61) + " Km\n";
	}

	if (document.getElementById("chkMeterToInch").checked) {
		rtbOutput.innerText += (parseFloat(input2) * 39.37) + " In\n";
	}
}
function Direction2() {
	var input2 = document.getElementById("inputBox2").value;
	var rtbOutput = document.getElementById("outputBox");

	if (document.getElementById("chkKilometersToMiles").checked) {
		rtbOutput.innerText += (parseFloat(input2) * 0.62) + " Miles\n";
	} 
	else if (document.getElementById("chkInchToMeter").checked) {
		rtbOutput.innerText += (parseFloat(input2) * 0.025) + " Meters\n";
	}
}