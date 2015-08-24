define(['jquery',
    'backbone',
    'marionette',
    'hbs!people/edit/main'],
    function ($, Backbone, Marionette, personview) {

        'use strict';

        return Marionette.ItemView.extend({
            template: personview,
            events: {
                'click [data-backbone]#cancel': 'cancel',
            },
            cancel: function (e) {
                e.preventDefault();
                Backbone.history.navigate('', { trigger: true });
            }
        });
    });