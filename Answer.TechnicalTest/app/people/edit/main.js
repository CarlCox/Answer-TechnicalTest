define(['jquery',
    'backbone',
    'marionette',
    'hbs!people/edit/main'],
    function ($, Backbone, Marionette, personview) {

        'use strict';

        return Marionette.ItemView.extend({
            template: personview
            
        });
    });