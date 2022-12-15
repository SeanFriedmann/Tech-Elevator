/**
 * Write a function called isAdmitted. It will check entrance
 * scores and return true if the student is admitted and
 * false if rejected. It takes three parameters:
 *
 *     * gpa
 *     * satScore (optional)
 *     * recommendation (optional)
 *
 * Admit them--return true--if:
 * gpa is above 4.0 OR
 * SAT score is above 1300 OR
 * gpa is above 3.0 and they have a recommendation OR
 * SAT score is above 1200 and they have a recommendation
 * OTHERWISE reject it
 *
 * @param {number} gpa the GPA of the student, between 4.2 and 1.0
 * @param {number} [satScore=0] the student's SAT score
 * @param {boolean} [recommendation=false] does the student have a recommendation
 * @returns {boolean} true if they are admitted
 */
    function isAdmitted(gpa, satScore, recommendation){
        if (gpa > 4.0 || satScore > 1300 || gpa > 3.0 && recommendation==true || satScore > 1200 && recommendation==true){
            return true;
        }
        return false;
    }

/**
 * Write a function called useParameterToFilterArray that accepts a filter function
 * as a parameter. Use this function to filter unfilteredArray and return the result.
 *
 * @param {function} filterFunction the function to filter with
 * @returns {number[]} the filtered array
 */
let unfilteredArray = [1, 2, 3, 4, 5, 6];

    function useParameterToFilterArray(filterFunction){
       filterFunction = unfilteredArray.filter(filterFunction);
       return filterFunction;
    } 
    

/**
 * Write a function called makeNumber that takes two strings
 * of digits, concatenates them together, and returns
 * the value as a number.
 *
 * So if two strings are passed in "42293" and "443", then this function
 * returns the number 42293443.
 *
 * @param {string} first the first string of digits to concatenate
 * @param {string} [second=''] the second string of digits to concatenate
 * @returns {number} the resultant number
 */
    function makeNumber(first, second = ""){ //allows it to take in one param
        const catWords = ' ' + first + second;
        const num = Number(catWords);
        return num;
    }

    
/**
 * Write a function called addAll that takes an unknown number of parameters
 * and adds all of them together. Return the sum.
 *
 * @param {...number} num a series of numbers to add together
 * @returns {number} the sum of all the parameters (or arguments)
 */
    function addAll(){
        let total = 0;
        for (let i = 0; i < arguments.length; i++){
            total += arguments[i];
        }
        return total;
    }
/*
 * Write and document a function called makeHappy that takes
 * an array and prepends 'Happy ' to the beginning of all the
 * words and returns them as a new array. Use the `map` function.
 */
/**
 * Takes in an array and returns an array with the word Happy in front of each element using the map function
 * @param {[]} startArray 
 * @returns {[]} newArray
 */

    function makeHappy(startArray){
        let newArray = startArray.map((element) => {
            return 'Happy' + ' ' + element;
        });
        return newArray;
    }
/*
 * Write and document a function called getFullAddressesOfProperties
 * that takes an array of JavaScript objects. Each object contains the
 * following keys:
 *     * streetNumber
 *     * streetName
 *     * streetType
 *     * city
 *     * state
 *     * zip
 *
 * getFullAddressesOfProperties returns an array of strings. 
 * Each string is a mailing address generated from the data of a single JavaScript object. 
 * 
 * Each mailing address should have the following format:
 *    
 *  streetNumber streetName streetType city state zip
 *
 * Use `map` and an anonymous function.
 */
    /**
     * 
     * @param {number} streetNumber
     * @param {string} streetNumber
     * @param {string} streetType
     * @param {string} city
     * @param {string} state;
     * @param {number} zip
     * @returns {string[]}
     */
    function getFullAddressesOfProperties(addressArray){
        let newArray = addressArray.map((element) => {
            return element.streetNumber + ' ' + element.streetName + ' ' + element.streetType + ' ' + element.city + ' ' + element.state + ' ' + element.zip;
        });
        return newArray
    }
    
/** 
 * Write and document a function called findLargest that uses `forEach`
 * to find the largest element in an array.
 * The function must work for strings and numbers.
 * 
 * For strings, "largest" means the word coming last in lexographical order.
 * Lexographic is similar to alphabetical order except that 
 * capital letters come before lowercase letters: 
 * 
 * "cat" < "dog" but "Dog" < "cat"
 *
 * @param {number[]|string[]} searchArray the array to search
 * @returns {number|string} the number or string that is largest
 **/
    function findLargest(searchArray){
        let largest = 0;
        let largeString = 'a';
        searchArray.forEach((element) => {
            if(largest < element){
                largest = element;
            }
        });
        return largest;
    }

/*
 * CHALLENGE
 * Write and document a function called getSumOfSubArrayValues.
 *
 * Take an array of arrays, adds up all sub values, and returns
 * the sum. For example, if you got this array as a parameter:
 * [
 *   [1, 2, 3],
 *   [2, 4, 6],
 *   [5, 10, 15]
 * ];
 *
 * The function returns 48. To do this, you will use two nested `reduce`
 * calls with two anonymous functions.
 *
 * Read the tests to verify you have the correct behavior.
 */
    function getSumOfSubArrayValues(array){
        
        let flattenedArray = [];

        if (array == undefined){
            return 0;
        }

        if (array.length == 0){
            return 0;
        }

        array.forEach(function(element){
            if (Array.isArray(element))
                flattenedArray.push(getSumOfSubArrayValues(element));
            else flattenedArray.push(element);
        });

        return flattenedArray.reduce(function(a,b){
            return a+b;
        });
    }
