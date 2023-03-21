﻿// Initialize and add the map
function initMap() {
    // The location of Uluru
    const uluru = { lat: 59.334591, lng: 18.063240 };
    // The map, centered at Uluru
    const map = new google.maps.Map(document.getElementById("modal_map"), {
        zoom: 8,
        center: uluru,
    });
    // The marker, positioned at Uluru
    const marker = new google.maps.Marker({
        position: uluru,
        map: map,
    });
}

window.initMap = initMap;