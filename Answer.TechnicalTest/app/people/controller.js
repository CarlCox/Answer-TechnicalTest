define(['marionette',
    'people/list/person',
    'people/list/main',
    'people/list/header'],
function (Marionette, PeopleView, PeopleModel, HeadListView) {

    'use strict';

    return Marionette.Controller.extend({
        list: function () {

            var people = new PeopleModel(),
                peopleView = new PeopleView({
                    collection: people
                }),
                headView = new HeadListView();

            var app = require('app');
            app.header.show(headView);
            var mainlayout = app.main;

            people.fetch().success(function () {
                mainlayout.show(peopleView);
                console.log(people);
            });
        }
    });

});