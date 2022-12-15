//grab the blue button
const blueBtn = document.getElementById('blueBtn');

//clear text area when we click the button
blueBtn.addEventListener('click', () => {  
    const txtArea = document.getElementById('txtArea');
    txtArea.value = "";
}); //second value is a function

const redBtn = document.getElementById('redBtn');

redBtn.addEventListener('click', function(event){
    const txtArea = document.getElementById('txtArea');
    txtArea.value = `The red button's event type was ${event.type}`; //will just display the event type aka click
});

//turn the whole box green
//make css for green back
const greenBtn = document.getElementById('greenBtn');

greenBtn.addEventListener('click', () => {
    const txtArea = document.getElementById('txtArea');
    //toggle will turn css class on/off
    txtArea.classList.toggle('greenbackGround');
    txtArea.value = "The green button was clicked";
    const title = document.querySelector('h1');
    title.innerText = "Website with a green button";
})

//get text input
const txtInput = document.getElementById('txtInput');
txtInput.addEventListener('keyup', (event) => {
    const para = document.getElementById('borderedPara');

    //i want to know if it was enter key that came up
    if (event.key === 'Enter'){
        //put value of text input in the paragraph tag
        para.innerText = txtInput.value;
    }
    if (event.key === '`'){
        displaySecretMessage(para);
    }
});

function displaySecretMessage(element){
    element.innerText = "Squirrel cigar party 6pm parking lot";
    //take in an element
}
