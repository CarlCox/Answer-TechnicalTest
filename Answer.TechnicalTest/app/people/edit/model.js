define([
    'backbone'
], function (Backbone) {
    'use strict';

    return Backbone.Model.extend({
        url: function () {
            return 'api/people/' + this.get('id');
        }
    });

});