define([
    'backbone'
], function (Backbone) {

    'use strict';

    var person = Backbone.Model.extend({
        idAttribute: 'id',
        url: function () {
            return '/api/person/' + this.get('id');
        }
    });

    return Backbone.Collection.extend({
        model: person,
        url: '/api/people'
    });

});