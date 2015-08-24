define(['jquery',
    'backbone',
    'marionette',
    'hbs!people/list/person',
    'hbs!people/list/main'],
    function ($, Backbone, Marionette, ListItem, List) {

        'use strict';

        var listitemview = Marionette.ItemView.extend({
            tagName: 'tr',
            template: ListItem
        });

        return Marionette.CompositeView.extend({
            template: List,
            childView: listitemview,
            childViewContainer: 'tbody'
        });

    });
