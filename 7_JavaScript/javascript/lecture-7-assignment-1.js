/*jslint
browser, devel, es6, for
*/
/*global
window
*/

// bitwise, browser, convert, couch, devel, es6, eval, fudge, getset, long, node, single, this, white

console.log(document.currentScript);

let stringOne = document.getElementById("stringOneInput").innerHTML;

let index;
let stringOneSplit;
let stringOneInterval;
stringOneSplit = stringOne.split("");
let arrayOnePop = [];
let arrayOneUnshift = [];
let arrayOneConcat = [];

function stringOneMove() {
    'use strict';
    arrayOnePop = stringOneSplit.pop();
    arrayOneUnshift.unshift(arrayOnePop);
    arrayOneConcat = arrayOneConcat.concat(arrayOneUnshift);
    document.getElementById("stringOneOutput").innerHTML += arrayOneUnshift.join("") + stringOneSplit.join("") + "<br>";
    if (stringOneSplit.length === 0) {
        clearInterval(stringOneInterval);
    }
}

function stringOneTimerStart() {
    'use strict';
    document.getElementById("stringOneOutput").innerHTML += stringOneSplit.join("") + "<br>";
    stringOneInterval = setInterval(stringOneMove, 1000);
}

stringOneTimerStart();
