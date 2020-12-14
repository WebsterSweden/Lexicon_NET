/*jslint
browser, devel, es6, for
*/
/*global
window
*/

// bitwise, browser, convert, couch, devel, es6, eval, fudge, getset, long, node, single, this, white

console.log(document.currentScript);

let firstNumber;
let firstNumberOutput;
let secondNumber;
let secondNumberOutput;
let targetValue = 100;

function nearestTo100() {
    'use strict';

    firstNumber = document.getElementById("firstNumber").value;
    // document.getElementById("firstNumberOutput").innerText = firstNumber;

    secondNumber = document.getElementById("secondNumber").value;
    // document.getElementById("secondNumberOutput").innerText = secondNumber;

    // firstNumber = null;
    // secondNumber = null;

    if (firstNumber === null || secondNumber === null) {
        document.getElementById("validationOutput").innerText = "Value can not be null.";
    } else if (firstNumber === "" || secondNumber === "") {
        document.getElementById("validationOutput").innerText = "Value can not be empty.";
    } else if (firstNumber.match(/^\s*$/) || secondNumber.match(/^\s*$/)) {
        document.getElementById("validationOutput").innerText = "Value can not be whitespace.";
    } else if (isNaN(firstNumber) || isNaN(secondNumber)) {
        document.getElementById("validationOutput").innerText = "Please enter a number.";
    } else if (firstNumber < 1 || secondNumber < 1) {
        document.getElementById("validationOutput").innerText = "Number have to be higher than 0.";
    } else if (firstNumber > 100 || secondNumber > 100) {
        document.getElementById("validationOutput").innerText = "Number have to be lower than " + targetValue + ".";
    } else if (firstNumber === secondNumber) {
        document.getElementById("validationOutput").innerText = "First number and second number can not be the same number.";
    } else if (firstNumber > secondNumber) {
        document.getElementById("result").innerHTML = "The first number is " + firstNumber + "." + "<br>" + "The second number is " + secondNumber + "." + "<br>" + "The first number is closest to " + targetValue + ".";
    } else if (firstNumber < secondNumber) {
        document.getElementById("result").innerHTML = "The first number is " + firstNumber + "." + "<br>" + "The second number is " + secondNumber + "." + "<br>" + "The second number is closest to " + targetValue + ".";
    } else {
        document.getElementById("result").innerText = "Unknown value.";
    }

    // Clear input.
    // Entered value is accepted.
    // Enter two different numbers.
}

document.getElementById("submit").addEventListener("click", nearestTo100);
