define(['marionette'],
function (Marionette) {

    'use strict';

    return Marionette.AppRouter.extend({
        appRoutes: {
            '': 'list',
            'edit/:id': 'edit'
        }
    });
});