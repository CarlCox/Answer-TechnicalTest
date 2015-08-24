define(['marionette'],
function (Marionette) {

    'use strict';

    return Marionette.AppRouter.extend({
        appRoutes: {
            '': 'list',
            'people': 'list',
            'edit/:id': 'edit'
        }
    });
});