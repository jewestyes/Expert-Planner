document.addEventListener('DOMContentLoaded', function () {
    const nav = document.querySelector('nav');
    const header = document.querySelector('header');

    header.addEventListener('mouseover', function () {
        nav.style.left = '0';
    });

    header.addEventListener('mouseout', function () {
        nav.style.left = '0';
    });
});