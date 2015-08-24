(function () {

    'use_strict';

    requirejs.config({
        paths: {
            backbone: "../Scripts/backbone",
            jquery: "../Scripts/jquery-1.9.1",
            marionette: "../Scripts/backbone.marionette",
            text: "../Scripts/text",
            underscore: "../Scripts/underscore",
            hbs: '../app/libs/hbs'
        },
        hbs: {
            templateExtension: 'html',
            helpers: true,
            helperPathCallback: function (name) {
                return '../plugins/handlebars/' + name;
            }
        },
        shim: {
            jquery: {
                exports: '$',
            },
            underscore: {
                exports: "_"
            },
            backbone: {
                deps: ["jquery", "underscore"],
                exports: "Backbone"
            },
            marionette: {
                deps: ['jquery', 'underscore', 'backbone'],
                exports: "Marionette"
            }
        }
    });

    require(["app"], function (app) {
        app.start();
    });
})();