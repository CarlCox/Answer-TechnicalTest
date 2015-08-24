define(['jquery',
    'backbone',
    'marionette',
    'hbs!people/list/person',
    'hbs!people/list/main'],
    function ($, Backbone, Marionette, ListItem, List) {

        'use strict';

        var listitemview = Marionette.ItemView.extend({
            tagName: 'tr',
            template: ListItem,
            events: {
                'click a': 'edit'
            },
            edit: function (e) {
                e.preventDefault();
                Backbone.history.navigate('edit/' + $(e.currentTarget).data('id'), { trigger: true });
            }
        });

        return Marionette.CompositeView.extend({
            template: List,
            childView: listitemview,
            childViewContainer: 'tbody'
        });

    });
