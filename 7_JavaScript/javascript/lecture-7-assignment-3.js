/*jslint
browser, devel, es6, for
*/
/*global
window
*/

// bitwise, browser, convert, couch, devel, es6, eval, fudge, getset, long, node, single, this, white

console.log(document.currentScript);

const dateObject = new Date();

document.getElementById("currentDate").innerText = dateObject.getDate();

// Convert month number to month name.
const monthNames = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];

const monthNumber = dateObject.getMonth();

const monthName = monthNames[monthNumber];

document.getElementById("currentMonth").innerText = monthName;

// Today's date as a number in milliseconds.
const timestamp = dateObject.getTime();

console.log(timestamp);

// Swedish Christmas Eve 2020.
// const christmasEve2020 = new Date("2020-12-24");
const christmasEve2020 = new Date("2020-12-24");

const christmasEve2020number = christmasEve2020.getTime();

console.log(christmasEve2020number);

// Calculate the milliseconds difference between current date and Swedish Christmas Eve.
const millisecondsDifference = timestamp - christmasEve2020number;

console.log(millisecondsDifference);

// Convert milliseconds to days.
// Round to next largest integer.
const daysDifference = Math.ceil(millisecondsDifference / (1000 * 60 * 60 * 24) - 1);

// Convert result to positive whole number.
const daysDifferenceAbsoluteNumber = Math.abs(Math.ceil(millisecondsDifference / (1000 * 60 * 60 * 24) - 1));

console.log(daysDifference);

if (daysDifference === 0) {
    document.getElementById("daysDifference").innerText = "It is Swedish Christmas Eve Today!";
} else if (daysDifference === -1) {
    document.getElementById("daysDifference").innerText = "The Swedish Christmas Eve is tomorrow (" + daysDifferenceAbsoluteNumber + " day).";
} else if (daysDifference < -1) {
    document.getElementById("daysDifference").innerText = "It is " + daysDifferenceAbsoluteNumber + " days to Swedish Christmas Eve.";
} else if (daysDifference === 1) {
    document.getElementById("daysDifference").innerText = "The Swedish Christmas Eve was yesterday (" + daysDifferenceAbsoluteNumber + " day ago).";
} else if (daysDifference > 1) {
    document.getElementById("daysDifference").innerText = "The Swedish Christmas Eve was " + daysDifferenceAbsoluteNumber + " days ago.";
} else {
    document.getElementById("daysDifference").innerText = "Unknown date.";
}
