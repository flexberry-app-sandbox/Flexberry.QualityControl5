import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  дата: DS.attr('date'),
  оборудование: DS.belongsTo('i-i-s-quality-control-оборудование', { inverse: null, async: false }),
  ответственный: DS.belongsTo('i-i-s-quality-control-сотрудник', { inverse: null, async: false }),
  проверяемые: DS.hasMany('i-i-s-quality-control-проверяемые', { inverse: 'отчет', async: false })
});

export let ValidationRules = {
  дата: {
    descriptionKey: 'models.i-i-s-quality-control-отчет.validations.дата.__caption__',
    validators: [
      validator('ds-error'),
      validator('date'),
    ],
  },
  оборудование: {
    descriptionKey: 'models.i-i-s-quality-control-отчет.validations.оборудование.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  ответственный: {
    descriptionKey: 'models.i-i-s-quality-control-отчет.validations.ответственный.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  проверяемые: {
    descriptionKey: 'models.i-i-s-quality-control-отчет.validations.проверяемые.__caption__',
    validators: [
      validator('ds-error'),
      validator('has-many'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ОтчетE', 'i-i-s-quality-control-отчет', {
    дата: attr('Дата', { index: 0 }),
    ответственный: belongsTo('i-i-s-quality-control-сотрудник', 'Ответственный', {
      номер: attr('Номер', { index: 2, hidden: true })
    }, { index: 1, displayMemberPath: 'номер' }),
    оборудование: belongsTo('i-i-s-quality-control-оборудование', 'Оборудование', {
      название: attr('Название', { index: 4, hidden: true })
    }, { index: 3, displayMemberPath: 'название' }),
    проверяемые: hasMany('i-i-s-quality-control-проверяемые', 'Проверяемые', {
      количество: attr('Количество', { index: 0 }),
      качество: attr('Качество', { index: 1 }),
      продукция: belongsTo('i-i-s-quality-control-продукция', 'Продукция', {
        название: attr('Название', { index: 3, hidden: true })
      }, { index: 2, displayMemberPath: 'название' })
    })
  });

  modelClass.defineProjection('ОтчетL', 'i-i-s-quality-control-отчет', {
    дата: attr('Дата', { index: 0 }),
    ответственный: belongsTo('i-i-s-quality-control-сотрудник', 'Номер', {
      номер: attr('Номер', { index: 1 })
    }, { index: -1, hidden: true }),
    оборудование: belongsTo('i-i-s-quality-control-оборудование', 'Название', {
      название: attr('Название', { index: 2 })
    }, { index: -1, hidden: true })
  });
};
