<template>
    <div class="main">
        <h1>{{ title }}</h1>
        <p>{{ description }}</p>
        <p>A great book by {{ kimBerry }}</p>

    <div class="well-display">
        <div class="well">
            <span class="amount">{{ averageRating }}</span>
            Average Rating
        </div>
        <div class="well">
            <span class="amount">{{numberOfOneStarReviews}}</span>
            1 Star Review{{numberOfOneStarReviews === 1 ? '' : 's'}}
        </div>
        <div class="well">
            <span class="amount">{{numberOfTwoStarReviews}}</span>
            2 Star Review{{numberOfTwoStarReviews === 1 ? '' : 's'}}
        </div>
        <div class="well">
            <span class="amount">{{numberOfThreeStarReviews}}</span>
            3 Star Review{{numberOfThreeStarReviews ===1 ? '' : 's'}}
        </div>
        <div class="well">
            <span class="amount">{{numberOfFourStarReviews}}</span>
            4 Star Review{{numberOfFourStarReviews === 1 ? '' : 's'}}
        </div>
        <div class="well">
            <span class="amount">{{numberOfFiveStarReviews}}</span>
            5 Star Review{{numberOfFiveStarReviews === 1 ? '' : 's'}}
        </div>
    </div>

         <div class="review" v-bind:class="{favorited:review.favorite}"
            v-for="review in reviews" v-bind:key="review">
            <!--makes us 4 nice boxes based off 4 reviews in the array -->
             <h4>{{review.reviewer}}</h4>
             <div class="rating">
                <img src="../assets/star.png" class="ratingStar"
                    v-for="star in review.rating" v-bind:key="star"/> 
             </div>
            <h3>{{review.title}}</h3>
            <p>{{review.review}}</p>
            <p>Favorite? <input type="checkbox" v-model="review.favorite"/></p>
            <!--starts off as not selected -->
        </div>
    </div>
</template>

<script>
export default { //
    name: 'product-review', //give the component a name
    data(){
        return {
            title:'Product Reviews for Cigar Parties for Dummies',
            description: 'Host and plan the perfect cigar party for all of your squirrelly friends.',
            kimBerry: 'Kim Berry',
            reviews: [
                {
                    reviewer: 'Malcolm Madwell',
                    title: 'What a book!',
                    review:
                    "It certainly is a book. I mean, I can see that. Pages kept together with glue and there's writing on it, in some language. Yes indeed, it is a book!",
                    rating: 3,
                    favorite: false
                },
                {
                    reviewer: 'Tim Ferriss',
                    title: 'Had a cigar party started in less than 4 hours.',
                    review:
                    "It should have been called the four hour cigar party. That's amazing. I have a new idea for muse because of this.",
                    rating: 4,
                    favorite: false
                },
                {
                    reviewer: 'Ramit Sethi',
                    title: 'What every new entrepreneurs needs. A door stop.',
                    review:
                    "When I sell my courses, I'm always telling people that if a book costs less than $20, they should just buy it. If they only learn one thing from it, it was worth it. Wish I learned something from this book.",
                    rating: 1,
                    favorite: false
                },
                {
                    reviewer: 'Gary Vaynerchuk',
                    title: 'And I thought I could write',
                    review:
                    "There are a lot of good, solid tips in this book. I don't want to ruin it, but prelighting all the cigars is worth the price of admission alone.",
                    rating: 3,
                    favorite: false
                }
                ]
        }
    },
    computed: {
        averageRating() {
            //add all ratings and divide by number of ratings
            let ratingSum = this.reviews.reduce((sum, nextReview) => {
                return sum + nextReview.rating
            }, 0);
            let numberOfReviews = this.reviews.length; //reviews is not defined in computed
            //need this. keyword to access outside of data function
           return ratingSum/numberOfReviews; 
        },
        numberOfOneStarReviews(){
            let oneStarReviews = this.reviews.filter((review) => {
                return review.rating == 1;
            })
            return oneStarReviews.length;
        },
        numberOfTwoStarReviews(){
            let twoStarReviews = this.reviews.filter((review) => {
                return review.rating == 2;
            })
            return twoStarReviews.length;
        },
        numberOfThreeStarReviews(){
            let threeStarReviews = this.reviews.filter((review) => {
                return review.rating == 3;
            })
            return threeStarReviews.length;
        },
        numberOfFourStarReviews(){
            let fourStarReviews = this.reviews.filter((review) => {
                return review.rating == 4;
            })
            return fourStarReviews.length;
        },
        numberOfFiveStarReviews(){
            let fiveStarReviews = this.reviews.filter((review) => {
                return review.rating == 5;
            })
            return fiveStarReviews.length;
        }
    }

}
</script>

<style>
div.main div.well-display {
    display: flex;
    justify-content: space-around;
}
div.main div.well-display div.well {
    display: inline-block;
    width: 15%;
    border: 1px black solid;
    border-radius: 6px;
    text-align: center;
    margin: 0.25rem;
}
div.main div.well-display div.well span.amount {
    color: darkslategray;
    display: block;
    font-size: 2.5rem;
}
div.main div.review {
    border: 1px black solid;
    border-radius: 6px;
    padding: 1rem;
    margin: 10px;
}
div.main div.review div.rating {
    height: 2rem;
    display: inline-block;
    vertical-align: top;
    margin: 0 0.5rem;
}
div.main div.review div.rating img {
    height: 100%;
}
div.main div.review p {
    margin: 20px;
}
div.main div.review h3 {
    display: inline-block;
}
div.main div.review h4 {
    font-size: 1rem;
}

div.main div.review.favorited {
    background-color: pink;
}

</style>