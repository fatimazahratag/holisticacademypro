// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// reveal pillars when in viewport
document.addEventListener('DOMContentLoaded', function () {
    const cards = document.querySelectorAll('.pillar-card');

    if ('IntersectionObserver' in window) {
        const obs = new IntersectionObserver((entries, observer) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    entry.target.classList.add('in-view');
                    observer.unobserve(entry.target);
                }
            });
        }, { threshold: 0.18 });

        cards.forEach(c => obs.observe(c));
    } else {
        // fallback: show all
        cards.forEach(c => c.classList.add('in-view'));
    }
});
