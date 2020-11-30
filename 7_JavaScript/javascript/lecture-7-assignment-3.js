/*jslint
browser, devel, es6
*/
/*global
window
*/

function dateNowFunction() {
    'use strict';
    var dateNow = new Date();
    document.getElementById("dateNow").innerText = dateNow;
}

document.getElementById("dateNowButton").addEventListener('click', dateNowFunction);
