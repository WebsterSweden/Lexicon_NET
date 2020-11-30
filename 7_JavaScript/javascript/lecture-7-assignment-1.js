/*jslint
browser, devel, es6
*/
/*global
window
*/

function stringOutputFunction() {
    'use strict';
    var stringOutputvariable = document.getElementById("string").innerText;
    document.getElementById("stringOutput").innerText = stringOutputvariable;
}

document.getElementById("stringOutputButton").addEventListener("click", stringOutputFunction);

function stringSplitFunction() {
    'use strict';
    var string = document.getElementById("string").innerText;
    var stringSplit = string.split("");
    document.getElementById("stringSplit").innerText = stringSplit;
}

document.getElementById("stringSplitButton").addEventListener("click", stringSplitFunction);

function stringReverseFunction() {
    'use strict';
    var string = document.getElementById("string").innerText;
    var stringSplit = string.split("");
    var stringReverse = stringSplit.reverse();
    document.getElementById("stringReverse").innerText = stringReverse;
}

document.getElementById("stringReverseButton").addEventListener("click", stringReverseFunction);

function stringJoinFunction() {
    'use strict';
    var string = document.getElementById("string").innerText;
    var stringSplit = string.split("");
    var stringReverse = stringSplit.reverse();
    var stringJoin = stringReverse.join("");
    document.getElementById("stringJoin").innerText = stringJoin;
}

document.getElementById("stringJoinButton").addEventListener("click", stringJoinFunction);

function stringSplitReverseJoinFunction() {
    'use strict';
    var string = document.getElementById("string").innerText;
    var stringSplit = string.split("");
    var stringReverse = stringSplit.reverse();
    var stringJoin = stringReverse.join("");
    document.getElementById("stringSplitReverseJoin").innerText = stringJoin;
}

document.getElementById("stringSplitReverseJoinButton").addEventListener("click", stringSplitReverseJoinFunction);
