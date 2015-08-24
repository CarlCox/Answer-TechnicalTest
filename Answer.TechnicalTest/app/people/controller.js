define(['marionette',
    'people/list/main',
    'people/list/model',
    'people/list/header',
    'people/edit/main',
    'people/edit/model',
    'people/edit/header'],
function (Marionette, PeopleView, PeopleModel, HeadListView, PersonEdit, PersonModel, HeadEditView) {

    'use strict';

    return Marionette.Controller.extend({
        list: function () {

            var people = new PeopleModel(),
                peopleView = new PeopleView({
                    collection: people
                }),
                headView = new HeadListView();

            var app = require('app');//need a better way of doing this.
            app.header.show(headView);
            var mainlayout = app.main;

            people.fetch().success(function () {
                mainlayout.show(peopleView);
                console.log(people);
            });
        },
        edit: function(id) {
            var person = new PersonModel({ id: id });
            var personView = new PersonEdit({
                model: person
            });

            var header = new HeadEditView({
                model: person
            });

            var app = require('app');//need a better way of doing this.
            person.fetch().success(function () {
                app.header.show(header);
                app.main.show(personView);
            });
        }
    });

});