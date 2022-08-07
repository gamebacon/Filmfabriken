function rand(min, max) {
    return min + Math.floor(Math.random() * (max - min));
}


function delay(t) {
    return new Promise(resolve => setTimeout(resolve, t));
}

async function getResults() {

    const results = [];
    
    const totalPages = 5;
    const startPageIndex = Math.max(1, rand(1, 500) - totalPages);
    
    for (let pageIndex = startPageIndex; pageIndex <= startPageIndex + totalPages; pageIndex++) {
        await delay(100);
        const url = API_URL + "&page=" + pageIndex;
        fetch(url).then(response => response.json()).then(json => 
            json.results.forEach(page => {
                results.push(page)
            })
        )
    }
    return results;
}