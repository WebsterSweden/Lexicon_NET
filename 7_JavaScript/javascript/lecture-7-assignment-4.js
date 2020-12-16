/*jslint
browser, devel, es6, for
*/
/*global
window
*/

// bitwise, browser, convert, couch, devel, es6, eval, fudge, getset, long, node, single, this, white

console.log(document.currentScript);

let word;
let wordToLowerCase;
let prefix = "abc";

function stringCreator() {
    'use strict';

    word = document.getElementById("stringInput").value;

    wordToLowerCase = word.toLowerCase();

    let stringConcatinate = prefix + word;

    if (wordToLowerCase.indexOf(prefix) === 0) {
        document.getElementById("stringOutput").innerText = word;
    } else {
        document.getElementById("stringOutput").innerText = stringConcatinate;
    }
}

document.getElementById("stringInputButton").addEventListener("click", stringCreator);
