﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.QualityControl
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Отчет.
    /// </summary>
    // *** Start programmer edit section *** (Отчет CustomAttributes)

    // *** End programmer edit section *** (Отчет CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("ОтчетE", new string[] {
            "Дата as \'Дата\'",
            "Ответственный as \'Ответственный\'",
            "Ответственный.Номер as \'Номер\'",
            "Оборудование as \'Оборудование\'",
            "Оборудование.Название as \'Название\'"}, Hidden=new string[] {
            "Ответственный.Номер",
            "Оборудование.Название"})]
    [AssociatedDetailViewAttribute("ОтчетE", "Проверяемые", "ПроверяемыеE", true, "", "Проверяемые", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("ОтчетE", "Ответственный", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Номер")]
    [MasterViewDefineAttribute("ОтчетE", "Оборудование", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Название")]
    [View("ОтчетL", new string[] {
            "Дата as \'Дата\'",
            "Ответственный.Номер as \'Номер\'",
            "Оборудование.Название as \'Название\'"})]
    public class Отчет : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fДата;
        
        private IIS.QualityControl.Сотрудник fОтветственный;
        
        private IIS.QualityControl.Оборудование fОборудование;
        
        private IIS.QualityControl.DetailArrayOfПроверяемые fПроверяемые;
        
        // *** Start programmer edit section *** (Отчет CustomMembers)

        // *** End programmer edit section *** (Отчет CustomMembers)

        
        /// <summary>
        /// Дата.
        /// </summary>
        // *** Start programmer edit section *** (Отчет.Дата CustomAttributes)

        // *** End programmer edit section *** (Отчет.Дата CustomAttributes)
        public virtual System.DateTime Дата
        {
            get
            {
                // *** Start programmer edit section *** (Отчет.Дата Get start)

                // *** End programmer edit section *** (Отчет.Дата Get start)
                System.DateTime result = this.fДата;
                // *** Start programmer edit section *** (Отчет.Дата Get end)

                // *** End programmer edit section *** (Отчет.Дата Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Отчет.Дата Set start)

                // *** End programmer edit section *** (Отчет.Дата Set start)
                this.fДата = value;
                // *** Start programmer edit section *** (Отчет.Дата Set end)

                // *** End programmer edit section *** (Отчет.Дата Set end)
            }
        }
        
        /// <summary>
        /// Отчет.
        /// </summary>
        // *** Start programmer edit section *** (Отчет.Оборудование CustomAttributes)

        // *** End programmer edit section *** (Отчет.Оборудование CustomAttributes)
        [PropertyStorage(new string[] {
                "Оборудование"})]
        [NotNull()]
        public virtual IIS.QualityControl.Оборудование Оборудование
        {
            get
            {
                // *** Start programmer edit section *** (Отчет.Оборудование Get start)

                // *** End programmer edit section *** (Отчет.Оборудование Get start)
                IIS.QualityControl.Оборудование result = this.fОборудование;
                // *** Start programmer edit section *** (Отчет.Оборудование Get end)

                // *** End programmer edit section *** (Отчет.Оборудование Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Отчет.Оборудование Set start)

                // *** End programmer edit section *** (Отчет.Оборудование Set start)
                this.fОборудование = value;
                // *** Start programmer edit section *** (Отчет.Оборудование Set end)

                // *** End programmer edit section *** (Отчет.Оборудование Set end)
            }
        }
        
        /// <summary>
        /// Отчет.
        /// </summary>
        // *** Start programmer edit section *** (Отчет.Ответственный CustomAttributes)

        // *** End programmer edit section *** (Отчет.Ответственный CustomAttributes)
        [PropertyStorage(new string[] {
                "Ответственный"})]
        [NotNull()]
        public virtual IIS.QualityControl.Сотрудник Ответственный
        {
            get
            {
                // *** Start programmer edit section *** (Отчет.Ответственный Get start)

                // *** End programmer edit section *** (Отчет.Ответственный Get start)
                IIS.QualityControl.Сотрудник result = this.fОтветственный;
                // *** Start programmer edit section *** (Отчет.Ответственный Get end)

                // *** End programmer edit section *** (Отчет.Ответственный Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Отчет.Ответственный Set start)

                // *** End programmer edit section *** (Отчет.Ответственный Set start)
                this.fОтветственный = value;
                // *** Start programmer edit section *** (Отчет.Ответственный Set end)

                // *** End programmer edit section *** (Отчет.Ответственный Set end)
            }
        }
        
        /// <summary>
        /// Отчет.
        /// </summary>
        // *** Start programmer edit section *** (Отчет.Проверяемые CustomAttributes)

        // *** End programmer edit section *** (Отчет.Проверяемые CustomAttributes)
        public virtual IIS.QualityControl.DetailArrayOfПроверяемые Проверяемые
        {
            get
            {
                // *** Start programmer edit section *** (Отчет.Проверяемые Get start)

                // *** End programmer edit section *** (Отчет.Проверяемые Get start)
                if ((this.fПроверяемые == null))
                {
                    this.fПроверяемые = new IIS.QualityControl.DetailArrayOfПроверяемые(this);
                }
                IIS.QualityControl.DetailArrayOfПроверяемые result = this.fПроверяемые;
                // *** Start programmer edit section *** (Отчет.Проверяемые Get end)

                // *** End programmer edit section *** (Отчет.Проверяемые Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Отчет.Проверяемые Set start)

                // *** End programmer edit section *** (Отчет.Проверяемые Set start)
                this.fПроверяемые = value;
                // *** Start programmer edit section *** (Отчет.Проверяемые Set end)

                // *** End programmer edit section *** (Отчет.Проверяемые Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "ОтчетE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОтчетE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОтчетE", typeof(IIS.QualityControl.Отчет));
                }
            }
            
            /// <summary>
            /// "ОтчетL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View ОтчетL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("ОтчетL", typeof(IIS.QualityControl.Отчет));
                }
            }
        }
    }
}
