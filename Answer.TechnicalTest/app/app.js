define(['backbone',
    'marionette',
    'people/router',
    'people/controller'],
    function (Backbone, Marionette, Router, Controller) {

        'use strict';

        var Application = Marionette.Application.extend({
            regions: function () {
                return {
                    header: '#header-region',
                    main: '#main-region'
                }
            }
        });

        var app = new Application();

        app.on('start', function () {

            this.Router = new Router({ controller: new Controller() });

            if (!Backbone.History.started) {
                Backbone.history.start();

                if (Backbone.history.fragment === '') {
                    Backbone.history.navigate('people', { trigger: true });
                }
            }
        });

        return app;
    });