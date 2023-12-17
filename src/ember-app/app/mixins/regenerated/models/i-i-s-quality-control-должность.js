import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  код: DS.attr('number'),
  название: DS.attr('string')
});

export let ValidationRules = {
  код: {
    descriptionKey: 'models.i-i-s-quality-control-должность.validations.код.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, allowBlank: true, integer: true }),
    ],
  },
  название: {
    descriptionKey: 'models.i-i-s-quality-control-должность.validations.название.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ДолжностьE', 'i-i-s-quality-control-должность', {
    код: attr('Код', { index: 0 }),
    название: attr('Название', { index: 1 })
  });

  modelClass.defineProjection('ДолжностьL', 'i-i-s-quality-control-должность', {
    код: attr('Код', { index: 0 }),
    название: attr('Название', { index: 1 })
  });
};
