/*jslint
browser, devel, es6, for
*/
/*global
window
*/

// bitwise, browser, convert, couch, devel, es6, eval, fudge, getset, long, node, single, this, white

console.log(document.currentScript);

function guessedFunction() {
    'use strict';

    let randomNumber = Math.floor(Math.random() * 10) + 1;
    let guessedNumber;
    let guess = "Enter a number between 1 and 10";
    let correctGuess = "Good Work" + "<br>" + "The guessed number is " + randomNumber;
    let wrongGuess = "Not matched";
    let cancel = "The application has terminated" + "<br>" + "Press the button to play again";

    console.log(randomNumber);

    document.getElementById("guessedNumberOutput").innerHTML = "";

    do {
        guessedNumber = prompt(guess);

        if (guessedNumber === null) {
            document.getElementById("guessedNumberOutput").innerHTML = cancel;
        } else if (parseInt(guessedNumber) === randomNumber) {
            document.getElementById("guessedNumberOutput").innerHTML = correctGuess;
        } else if (parseInt(guessedNumber) !== randomNumber) {
            guessedNumber = prompt(wrongGuess);
        }
    } while (parseInt(guessedNumber) !== randomNumber && guessedNumber !== null);
}

document.getElementById("guessButton").addEventListener("click", guessedFunction);
