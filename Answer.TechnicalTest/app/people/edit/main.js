define(['jquery',
    'backbone',
    'marionette',
    'hbs!people/edit/main'],
    function ($, Backbone, Marionette, personview) {

        'use strict';

        return Marionette.ItemView.extend({
            template: personview,
            events: {
                'click [data-backbone]#cancel': 'cancel',
                'click [data-backbone]#save': 'save',
                'click label': 'hidecheckbox'
            },
            cancel: function (e) {
                e.preventDefault();
                Backbone.history.navigate('', { trigger: true });
            },
            save: function(e) {
                e.preventDefault();

                var model = this.model,
                colours = model.get('colours');
                model.set('isAuthorised', $('input:checkbox[name=authorised]').is(':checked'));
                model.set('isEnabled', $('input:checkbox[name=enabled]').is(':checked'));

                $('.colours input:checkbox').each(function (i) {
                    var $this = $(this),
                    selected = $this.is(':checked'),
                    id = $this.data().id;

                    $.grep(colours, function (i) {
                        if (i.id === id) {
                            i.isSelected = selected;
                        }
                    });
                });

                model.set('colours', colours);
                model.save().done(function () {
                    Backbone.history.navigate('', { trigger: true });
                });
            },
            hidecheckbox: function(e) {
                e.preventDefault();
                $(e.currentTarget).parent().find('input[type="checkbox"]').toggle();
            }
        });
    });