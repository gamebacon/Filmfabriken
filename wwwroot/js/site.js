// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const API_KEY = "1c345153a54c683b1844784f665df566";
const BASE_URL = "https://api.themoviedb.org/3"
const API_URL = BASE_URL + "/discover/movie?sort_by=popularity.desc&api_key=" + API_KEY;
const IMG_URL = "https://image.tmdb.org/t/p/w500";
const main = document.getElementById('main');

getMovies(API_URL)

    function getMovies(url) {
        console.log("Fetching: " + url)
        fetch(url).then(res => res.json()).then(data => {
            showMovies(data.results)
        })
    }

    function getRatingColor(rating) {
        return rating > 7.5  ? "green" : rating > 4.5 ? "yellow" : "red";
    }

    function showMovies(data) {
        main.innerHTML = '';
        
        data.forEach(movie => {
            const {title, poster_path, vote_average, overview} = movie;
            const movieE1 = document.createElement('div');
            movieE1.classList.add('movie');
            movie_layout =      
                `
                <div class="image-container">
                    <img class="image" src=${IMG_URL + poster_path} alt="${title}">
                    <div class="middle">
                        <div class="text">${overview}</div>
                    </div>
                </div>
                <div class="p-2 overview">
                    <div class="movie-heading">
                        <h3>${title}</h3>
                        <span class="${getRatingColor(vote_average)} rating">${vote_average}</span>
                    </div>
                    <hb/>
                    <span class="font-weight-light">${overview}</span>
                </div>
                `;
            
            
            movieE1.innerHTML = movie_layout;
            main.appendChild(movieE1)
        })
    }
