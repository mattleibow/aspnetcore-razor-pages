(function () {
    var date = new Date();
    var dateElement = document.getElementById('date');
    dateElement.innerText = date.toLocaleDateString();
})();
