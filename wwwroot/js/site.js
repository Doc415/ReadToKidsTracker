// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

const { start } = require("@popperjs/core");

// Write your JavaScript code.


function deleteSession(id) {
    fetch(`/Home/Delete/${id}`, {
        method: 'POST'
    })
        .then(response => {
            window.location.href = '/Home/Index';
        })
}
