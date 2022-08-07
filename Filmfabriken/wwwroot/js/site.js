// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const API_KEY = "1c345153a54c683b1844784f665df566";
const BASE_URL = "https://api.themoviedb.org/3"
const IMG_URL = "https://image.tmdb.org/t/p/w500";

const API_URL = BASE_URL + "/discover/movie?sort_by=popularity.desc&api_key=" + API_KEY;
const SEARCH_URL = BASE_URL + "/search/movie?api_key=" + API_KEY;





const main = document.getElementById('main');

const search_button = document.getElementById('search-button');
const search_input = document.getElementById('search-input');

const list_search = document.getElementById('movie-list-search')
const list_search_parent = document.getElementById('movie-list-search-parent')
const home = document.getElementById('home-p')



if(home) {
    testA();
}



function testA() {
    home.innerHTML = '';


    getResults().then(movies => {
        movies.forEach(movie => {
            
            const {id, title, poster_path, vote_average, overview} = movie;
            
            const image_path = IMG_URL + poster_path;
            
            const element = document.createElement("div");
            element.id = id;
            element.classList.add("home-item")
            element.innerHTML =

                `
                    <div class="">
                        <a href="movies/moviedetails/?movie_id=${id}">
                            <img class="home-poster" src="${image_path}"/>
                        </a>
                    </div>
                `;
            
            home.appendChild(element)
            
        })
    });

}

if(list_search) {
    list_search.addEventListener("input", e => {
        let searchTerm = list_search.value;

        list_search_parent.innerHTML = '';
        

        if(searchTerm) {
            fetch(SEARCH_URL + "&limit=5&query=" + searchTerm).then(res => res.json()).then(data => {
                data.results.forEach( movie => {
                    const {id, title, poster_path, vote_average, overview} = movie;
                    const movieE1 = document.createElement("div");
                    movieE1.id = id;
                    movieE1.classList.add("movie-list-search-item")
                    movieE1.innerHTML = `
                        <li>
                            <div class="">
                                <img class="movie-edit-list-img" src="${IMG_URL + poster_path}"/>
                                <div class="movie-add-item">
                                    <span class="font-weight-bold">${title}</span>
                                    <br>
                                    <input type="checkbox" name="CategoryId" value="${id}">Lägg till<br />
                                </div>
                            </div>
                        </li>
                    `;
                    list_search_parent.appendChild(movieE1) 
                });
            })
        }
    });
}
/*

    function addToList(id) {
        url = BASE_URL + "/movie/" + id + "?api_key=" + API_KEY;
        const movie = document.createElement('div');

        $.getJSON(url, function(data) {
            movie.innerHTML = `
            <li>${data.title}</li>
            `
        });
        
        list_finish.appendChild(movie)

    }
 */


if(main) {
    
    getMovies(API_URL);
    
    search_button.addEventListener("click", e => {

        e.preventDefault();

        const searchTerm = search_input.value;

        if(searchTerm) {
            searchMovies(searchTerm);
        }
    });
}


    function getMovies(url) {
        console.log("Fetching: " + url)
        fetch(url).then(res => res.json()).then(data => {
            showMovies(data.results)
        })
        
    }

    function getRatingColor(rating) {
        return rating > 6  ? "green" : rating > 4.5 ? "yellow" : "red";
    }
    
    function searchMovies(search) {
        getMovies(SEARCH_URL + "&query=" + search)
    }
    
    function showMovies(data) {
        main.innerHTML = '';
        
        
        data.forEach(movie => {
            const {id, title, poster_path, vote_average, overview} = movie;
            const movieE1 = document.createElement('div');
            movieE1.id = id;
            movieE1.classList.add('movie');
            
            movie_layout =      
                `
                <div class="image-container">
                
                    <a href="movies/moviedetails/?movie_id=${id}">
                        <img class="image" src=${IMG_URL + poster_path} alt="${title}">
                    </a>
                    
                </div>
                
                <div class="overview">
                    <div class="movie-heading">
                        <span>${title}</span>
                        <div>
                            <span class="${getRatingColor(vote_average)} rating">${vote_average.toFixed(1)}</span>
                        </div>
                    </div>
                    <hb/>
                    <span class="">${overview}</span>
                </div>
                
                `;
            
            
            movieE1.innerHTML = movie_layout;
            main.appendChild(movieE1)
        })
    }


    
 
