//setup 10 problem string array from math.random, values 0-9, multiplication
//forrach question, 1 rigt answer, 3 rng incorrect answer, up to 81

/**
 * 
 * @param {*} max 
 * @returns {number}
 */

function getRandomNumber(max){
    return Math.floor(Math.random() * Math.floor(10));
}

const questionsArray = ['4 * 3', '5 * 7', '9 * 2', '5 * 5', '6 * 9', '7 * 6', '1 * 1', '0 * 1', '8 * 8', '1* 7'];
const answersArray = [12, 35, 18, 25, 54, 42, 1, 0, 64, 7];

const startBtn = document.getElementById('btnStartOver');
startBtn.addEventListener('click', (event) => {

});