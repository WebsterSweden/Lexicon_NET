/*jslint
browser, devel, es6
*/
/*global
window
*/

function stringOutputMethod() {
    'use strict';
    let stringInput = document.getElementById("stringInput").innerText;
    let stringOutput = document.getElementById("stringOutput");
    stringOutput.innerText = "string output: " + stringInput;
}

document.getElementById("stringButton").addEventListener("click", stringOutputMethod);

function stringToArrayMethod() {
    'use strict';
    let stringInput = document.getElementById("stringInput").innerText;
    let stringToArrayOutput = document.getElementById("stringToArrayOutput");
    stringToArrayOutput.innerText = "string to array: " + stringInput.split("");
}

document.getElementById("stringToArrayButton").addEventListener("click", stringToArrayMethod);

function reverseArrayMethod() {
    'use strict';
    let stringInput = document.getElementById("stringInput").innerText;
    let stringToArrayOutput = stringInput.split("");
    let reverseArrayOutput = document.getElementById("reverseArrayOutput");
    reverseArrayOutput.innerText = "reverse array: " + stringToArrayOutput.reverse();
}

document.getElementById("reverseArrayButton").addEventListener("click", reverseArrayMethod);

function arrayToStringMethod() {
    'use strict';
    let stringInput = document.getElementById("stringInput").innerText;
    let stringToArrayOutput = stringInput.split("");
    let reverseArrayOutput = document.getElementById("reverseArrayOutput");
    reverseArrayOutput = stringToArrayOutput.reverse();
    let arrayToStringOutput = document.getElementById("arrayToStringOutput");
    arrayToStringOutput.innerText = "array to string: " + reverseArrayOutput.join("");
}

document.getElementById("arrayToStringButton").addEventListener("click", arrayToStringMethod);

function reload() {
    'use strict';
    location.reload();
}

document.getElementById("reload").addEventListener("click", reload);
