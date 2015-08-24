define([
    'backbone'
], function (Backbone) {

    'use strict';

    var person = Backbone.Model.extend({
        
    });

    return Backbone.Collection.extend({
        model: person,
        url: '/api/people'
    });

});