const book_name = 'Cigar Parties for Dummies';
const description = 'Host and plan the perfect cigar party for all of your squirrelly friends.';
const reviews = [
  {
    reviewer: 'Malcolm Madwell',
    title: 'What a book!',
    review:
    "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language. Yes indeed, it is a book!",
    rating: 3
  },
  {
    reviewer: 'Tim Ferriss',
    title: 'Had a cigar party started in less than 4 hours.',
    review:
      "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
    rating: 4
  },
  {
    reviewer: 'Ramit Sethi',
    title: 'What every new entrepreneurs needs. A door stop.',
    review:
      "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
    rating: 1
  },
  {
    reviewer: 'Gary Vaynerchuk',
    title: 'And I thought I could write',
    review:
      "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
    rating: 3
  }
];

/**
 * Add the product name to the page title
 * Get the page title by the id and the query the .name selector
 * once you have the element you can add the product name to the span.
 */
function setPageTitle() {
  //get page title h1
  const pageTitle = document.getElementById('page-title'); //
  const pageTitleSpan = pageTitle.querySelector('.name'); //find thing in h1 with class name 
  //put book title inside span
  pageTitleSpan.innerText = book_name;

}

/**
 * Add the product description to the page.
 */
function setPageDescription() {
  //get the <p> class desc and put it in 
  const pageDesc = document.querySelector('.description');
  pageDesc.innerText = description;
}

/**
 * Display all of the reviews on the page.
 * Loop over the array of reviews and use some helper functions
 * to create the elements needed for the markup and add them to the DOM.
 */
function displayReviews() {
  //build review boxes
   const main = document.getElementById('main');

   //4 boxes
   reviews.forEach((review) => {
      //use doc.createEle to make a new div ex. 'div', 'span' 'p'
    const container = document.createElement('div');
    container.classList.add('review');

    //call addReviewer function to get reviewer's name in the div 
    //parent element is container, name is reviewer var
    addReviewer(container, review.reviewer);

    //addRating to see the stars
    addRating(container, review.rating);

    //add title
    addTitle(container, review.title);

    addReview(container, review.review);

    //insert our new div into dom, decide where to put it
    main.insertAdjacentElement('beforeend', container);
    //puts it before teh he end tag
    //first param changes the placement of where it is put
   });


}

/**
 * Create a new h2 element with the name of the reviewer and append it to
 * the parent element that is passed to me.
 *
 * @param {HTMLElement} parent: The element to append the reviewer to
 * @param {string} name The name of the reviewer
 */
function addReviewer(parent, name) { //parent element, name of reviewer\
  //make an h2
  const reviewer = document.createElement('h2'); //create h2 element for reviewer name
  reviewer.innerText = name; //set innerText to the review's name



  //parent element of the function, add the reviewer on as the last child of the parent
  parent.appendChild(reviewer);

}

/**
 * Add the rating div along with a star image for the number of ratings 1-5
 * @param {HTMLElement} parent
 * @param {Number} numberOfStars
 */
function addRating(parent, numberOfStars) {
  //create div to hold star ratings
  const ratingDiv = document.createElement('div');
  ratingDiv.classList.add('rating');

  //put number of stars based on correct rating
  //count until you reach the number of stars per review
  for(let i = 0; i < numberOfStars; i++){
    //add a star in the ratingDiv
    //add image with img tag
    const star = document.createElement('img');
    star.src = 'img/star.png'; //can do this

    //takes 2 params, attribute and val
   // starImg.setAttribute('src', 'img/star.png');
    //star.classList.add('ratingStar'); //add css class

    //append to rating div
   ratingDiv.appendChild(star);
  } //end of for loop
  parent.appendChild(ratingDiv);
}

/**
 * Add an h3 element along with the review title
 * @param {HTMLElement} parent
 * @param {string} title
 */
function addTitle(parent, title) {
  //create the h3
  const reviewTitle = document.createElement('h3');

  //put the title in it
  reviewTitle.innerText = title;

  //attach it to the parent
  parent.appendChild(reviewTitle);
}

/**
 * Add the product review
 * @param {HTMLElement} parent
 * @param {string} review
 */
function addReview(parent, review) {
  const reviewerReview = document.createElement('p');

  //reviewerReview.innerText = review;
  reviewerReview.innerHTML = 'Some fun words <strong>fun words</strong><div>Here is a div!</div><h6>here is an h6</h6>';

  parent.appendChild(reviewerReview);

}

// set the product reviews page title
setPageTitle();
// set the product reviews page description
setPageDescription();
// display all of the product reviews on the page
displayReviews();
