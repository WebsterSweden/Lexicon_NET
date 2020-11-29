/*jslint devel, browser */
/*global
window
*/

// Check if the JavaScript file is linked and active.
function filename() {
    "use strict";
    console.log(document.currentScript);
}

filename();

// History back button.
function goBack() {
    "use strict";
    window.history.back();
}

// Add onclick event on button.
window.onload = function () {
    "use strict";
    document.getElementById("goBackButton").addEventListener("click", goBack);
};
