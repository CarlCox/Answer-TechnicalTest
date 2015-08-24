define(['jquery',
    'backbone',
    'marionette',
    'hbs!people/list/header'],
    function ($, Backbone, Marionette, HeadTemplate) {

        'use strict';

        return Marionette.ItemView.extend({
            tagName: 'h1',
            template: HeadTemplate
        });
    });

