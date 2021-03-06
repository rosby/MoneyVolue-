using System;
using System.Collections.Generic;
using System.Text;
using NsgSoft.DataObjects;
using NsgSoft.Design;
using System.IO;
using NsgSoft.Common;

namespace Val.Метаданные
{
    public partial class Метаданные : NsgSoft.DataObjects.NsgMetaData
    {
        #region Данные
        #endregion //Данные

        #region Инициализация


        public static Метаданные Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("4643bc92-4a00-4f89-9da3-e292cff11bdb"));
            if (obj == null)
                obj = new Метаданные();
            return obj as Метаданные;
        }

        /// <summary>
        /// Инициализация
        /// </summary>
        protected override void InitObjectList()
        {
            ObjectList.AddRange( new NsgMultipleObject[] {Val.Метаданные.Сервис.DataAssemblyObject.Новый(),
	 Val.Метаданные.Сервис.БазыДанныхДляОбмена.Новый(),
	 Val.Метаданные.Сервис.ОбъектыОбмена.Новый(),
	 Val.Метаданные.Сервис.ТипыОбмена.Новый(),
	 Val.Метаданные.Сервис.ПравилаОбменаДанными.Новый(),
	 Val.Метаданные.Сервис.ПротоколОбмена.Новый(),
	 Val.Метаданные.Сервис.НастройкиКаналаОбмена.Новый(),
	 Val.Метаданные.Сервис.ОбменДанными.Новый(),
	 Val.Метаданные.Сервис.ИмпортДанных.Новый(),
	 Val.Метаданные.Сервис.СервисноеОбслуживание.Новый(),
	 Val.Метаданные.Сервис.СостоянияОбъекта.Новый(),
	 Val.Метаданные.Сервис.ВидыДвижений.Новый(),
	 Val.Метаданные.Сервис.ОбщийЖурнал.Новый(),
	 Val.Метаданные.Сервис.НеактуальностьИтоговРегистров.Новый(),
	 Val.Метаданные.Сервис.ПечатныеФормы.Новый(),
	 Val.Метаданные._SystemTables.СервисПечатныеФормыДвижения.Новый(),
	 Val.Метаданные.Сервис.КорректировкаРегистра.Новый(),
	 Val.Метаданные._SystemTables.PeriodicTable.Новый(),
	 Val.Метаданные.Сервис.ДействияПользователей.Новый(),
	 Val.Метаданные.Сервис.РазрешениеОперацииПользователя.Новый(),
	 Val.Метаданные.Сервис.Пользователи.Новый(),
	 Val.Метаданные._SystemTables.РолиПользователя.Новый(),
	 Val.Метаданные.Сервис.ТипСообщения.Новый(),
	 Val.Метаданные.Сервис.СписокСообщений.Новый(),
	 Val.Метаданные.Сервис.Приоритет.Новый(),
	 Val.Метаданные.Сервис.ТипЗадачиНаСервере.Новый(),
	 Val.Метаданные.Сервис.СервернаяЗадача.Новый(),
	 Val.Метаданные.Сервис.НастройкиПользователей.Новый(),
	 Val.Метаданные.Сервис.ПраваПользователей.Новый(),
	 Val.Метаданные._SystemTables.СервисПраваПользователейДвижения.Новый(),
	 Val.Метаданные.Сервис.ОбновленияСистемы.Новый(),
	 Val.Метаданные.Сервис.ТаблицаРолиМенюПользователя.Новый(),
	 Val.Метаданные.Сервис.РольПользователяМеню.Новый(),
	 Val.Метаданные.Сервис.ДействиеЭлементаМеню.Новый(),
	 Val.Метаданные.Сервис.ТаблицаЭлементаМенюПользователя.Новый(),
	 Val.Метаданные.Сервис.ЭлементМенюПользователя.Новый(),
	 Val.Метаданные.Деньги.ИсторияКурсов.Новый(),
	 Val.Метаданные.Деньги.Валюты.Новый(),
	 Val.Метаданные.Деньги.ЗагрузкаКурсов.Новый()});
        }
        
        /// <summary>
        /// Инициализация
        /// </summary>
        private void InitializeComponent()
        {
            	//NsgMetaData
	IsLoadedFromDll = true;
	Guid = NsgService.StringToGuid("4643bc92-4a00-4f89-9da3-e292cff11bdb");
	PeriodicTable = "_SystemTables.PeriodicTable";
	SystemGroup = "_SystemTables";
	Version = "2021.4.29.3";
	ContainsUserInformation = true;
	UserActionsRegisteration = true;
	UseUserMenu = true;
	Groups = new System.String[]{"Сервис", "Деньги"};
	Name = "Метаданные";
	
            AfterLoad();
        }

        #endregion //Инициализация

        #region Свойства
        #endregion //Свойства

        #region Методы
        /// <summary>
        /// Идентификатор текущего уровня метаданных
        /// </summary>
        private string ID
        {
            get
            {
                return "Val";
            }
        }
        #endregion //Методы
    }
}
