using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.ComponentModel;
using System.IO;

using NsgSoft.DataObjects;
using NsgSoft.Design;
using NsgSoft.Database;
using NsgSoft.Common;

// ================================================================ //
// Этот файл создается автоматически, все изменения будут потеряны. //
// ================================================================ //

namespace Val.Метаданные.Сервис
{
    
    [NsgTypeName("NsgDataRegistrationJournal", Guid = "e001598f-6f00-430d-9056-cd84fd4011d2")]
    public partial class ДействияПользователей : NsgSoft.DataObjects.NsgDataRegistrationJournal
    {
        #region Данные
        #region Данные NsgSoft.DataObjects.NsgDataRegistrationJournal
        




        #endregion // Данные NsgSoft.DataObjects.NsgDataRegistrationJournal

        #endregion // Данные

        #region Конструкторы 
        #region Конструкторы NsgSoft.DataObjects.NsgDataRegistrationJournal
        




        #endregion // Конструкторы NsgSoft.DataObjects.NsgDataRegistrationJournal

        /// <summary>
        /// Создание объекта
        /// </summary>
        protected ДействияПользователей()
            : base()
        {
        }

        /// <summary>
        ///  Создание объекта Clone.
        /// </summary>
        protected ДействияПользователей(NsgObject obj)
            : base(obj)
        {
        }

        #endregion // Конструкторы 

        #region Инициализация
        public static ДействияПользователей Новый()
        {
            NsgBaseObject obj = CreateByGuid(NsgService.StringToGuid("e001598f-6f00-430d-9056-cd84fd4011d2"));
            if (obj == null)
                obj = new ДействияПользователей();
            return obj as ДействияПользователей;
        }

        /// <summary>
        /// Инициализация реквизитов объекта
        /// </summary>
        protected override void CreatePreDefinedFields()
		{
			#region необходимые операции до создания реквизитов и заполнения полей
			if (NsgSettings.Regime == NsgSoft.Common.NsgViewTypes.Load)
                base.CreatePreDefinedFields();
			#endregion //необходимые операции до создания реквизитов и заполнения полей
			#region начало инициализации NsgSoft.DataObjects.NsgDataRegistrationJournal
			




			#endregion //начало инициализации NsgSoft.DataObjects.NsgDataRegistrationJournal
			
			#region создание System.Guid Идентификатор
			{  
                NsgDataGuid Идентификатор = null;
				if (ObjectList.Contains("Идентификатор"))
                    Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                else
                    Идентификатор = new NsgDataGuid();
	//NsgDataGuid
	Идентификатор.IsLoadedFromDll = true;
	Идентификатор.StringFormat = "";
	Идентификатор.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Идентификатор.IncludeInPredefined = false;
	Идентификатор.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Идентификатор.Required = false;
	Идентификатор.EmptyValue = "";
	Идентификатор.NullAllow = false;
	Идентификатор.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Идентификатор.FieldName = "_ID";
	Идентификатор.SaveInDatabase = true;
	Идентификатор.InformMetaDataOnValueChanged = false;
	Идентификатор.Visible = true;
	Идентификатор.Name = "Идентификатор";
	Идентификатор.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Идентификатор.Description = "Идентификатор";
	Идентификатор.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.ReadOnly;
	Идентификатор.GroupName = "";
	Идентификатор.Guid = NsgService.StringToGuid("6a6168d0-6449-4e78-897f-fd8bf52074d3");
	
				if (!ObjectList.Contains("Идентификатор"))
                    ObjectList.Add(Идентификатор);
			}
			#endregion //создание System.Guid Идентификатор
			
			#region создание System.Int64 Автоинкремент
			{  
                NsgDataInteger Автоинкремент = null;
				if (ObjectList.Contains("Автоинкремент"))
                    Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                else
                    Автоинкремент = new NsgDataInteger();
	//NsgDataInteger
	Автоинкремент.IsLoadedFromDll = true;
	Автоинкремент.DefaultValue = 0M;
	Автоинкремент.MinValue = 0M;
	Автоинкремент.MaxValue = 0M;
	Автоинкремент.UseCalculator = true;
	Автоинкремент.StringFormat = "";
	Автоинкремент.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Автоинкремент.IncludeInPredefined = false;
	Автоинкремент.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Автоинкремент.Required = false;
	Автоинкремент.EmptyValue = "";
	Автоинкремент.NullAllow = false;
	Автоинкремент.IndexType = NsgSoft.Database.NsgRekvisitIndexType.UniqueControl;
	Автоинкремент.FieldName = "_AutoInc";
	Автоинкремент.SaveInDatabase = true;
	Автоинкремент.InformMetaDataOnValueChanged = false;
	Автоинкремент.Visible = true;
	Автоинкремент.Name = "Автоинкремент";
	Автоинкремент.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	Автоинкремент.Description = "Автоинкремент";
	Автоинкремент.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Hidden;
	Автоинкремент.GroupName = "";
	Автоинкремент.Guid = NsgService.StringToGuid("531645fb-5467-4def-80c2-c136b8479a2b");
	
				if (!ObjectList.Contains("Автоинкремент"))
                    ObjectList.Add(Автоинкремент);
			}
			#endregion //создание System.Int64 Автоинкремент
			
			#region создание System.DateTime ДатаВремя
			{  
                NsgDataDateTime ДатаВремя = null;
				if (ObjectList.Contains("ДатаВремя"))
                    ДатаВремя = ObjectList["ДатаВремя"] as NsgDataDateTime;
                else
                    ДатаВремя = new NsgDataDateTime();
	//NsgDataDateTime
	ДатаВремя.IsLoadedFromDll = true;
	ДатаВремя.Format = NsgSoft.Common.NsgDateTimeFormat.DateTime;
	ДатаВремя.StringFormat = "";
	ДатаВремя.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ДатаВремя.IncludeInPredefined = false;
	ДатаВремя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ДатаВремя.Required = false;
	ДатаВремя.EmptyValue = "";
	ДатаВремя.NullAllow = false;
	ДатаВремя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ДатаВремя.FieldName = "_Date";
	ДатаВремя.SaveInDatabase = true;
	ДатаВремя.InformMetaDataOnValueChanged = false;
	ДатаВремя.Visible = true;
	ДатаВремя.Name = "ДатаВремя";
	ДатаВремя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Дата и время"});
	ДатаВремя.Description = "Дата и время";
	ДатаВремя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ДатаВремя.GroupName = "";
	ДатаВремя.Guid = NsgService.StringToGuid("1f64c2ea-8011-45dd-9901-56242444e1f1");
	
				if (!ObjectList.Contains("ДатаВремя"))
                    ObjectList.Add(ДатаВремя);
			}
			#endregion //создание System.DateTime ДатаВремя
			
			#region создание System.String Пользователь
			{  
                NsgDataString Пользователь = null;
				if (ObjectList.Contains("Пользователь"))
                    Пользователь = ObjectList["Пользователь"] as NsgDataString;
                else
                    Пользователь = new NsgDataString();
	//NsgDataString
	Пользователь.IsLoadedFromDll = true;
	Пользователь.Length = 100;
	Пользователь.StringFormat = "";
	Пользователь.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Пользователь.IncludeInPredefined = false;
	Пользователь.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Пользователь.Required = false;
	Пользователь.EmptyValue = "";
	Пользователь.NullAllow = false;
	Пользователь.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Пользователь.FieldName = "_User";
	Пользователь.SaveInDatabase = true;
	Пользователь.InformMetaDataOnValueChanged = false;
	Пользователь.Visible = true;
	Пользователь.Name = "Пользователь";
	Пользователь.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Пользователь"});
	Пользователь.Description = "Пользователь";
	Пользователь.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Пользователь.GroupName = "";
	Пользователь.Guid = NsgService.StringToGuid("129d523f-e3f2-46b7-a63d-3f6eaf44201d");
	
				if (!ObjectList.Contains("Пользователь"))
                    ObjectList.Add(Пользователь);
			}
			#endregion //создание System.String Пользователь
			
			#region создание System.Guid ИдентификаторПользователя
			{  
                NsgDataGuid ИдентификаторПользователя = null;
				if (ObjectList.Contains("ИдентификаторПользователя"))
                    ИдентификаторПользователя = ObjectList["ИдентификаторПользователя"] as NsgDataGuid;
                else
                    ИдентификаторПользователя = new NsgDataGuid();
	//NsgDataGuid
	ИдентификаторПользователя.IsLoadedFromDll = true;
	ИдентификаторПользователя.StringFormat = "";
	ИдентификаторПользователя.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИдентификаторПользователя.IncludeInPredefined = false;
	ИдентификаторПользователя.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИдентификаторПользователя.Required = false;
	ИдентификаторПользователя.EmptyValue = "";
	ИдентификаторПользователя.NullAllow = false;
	ИдентификаторПользователя.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ИдентификаторПользователя.FieldName = "_UserID";
	ИдентификаторПользователя.SaveInDatabase = true;
	ИдентификаторПользователя.InformMetaDataOnValueChanged = false;
	ИдентификаторПользователя.Visible = true;
	ИдентификаторПользователя.Name = "ИдентификаторПользователя";
	ИдентификаторПользователя.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Идентификатор пользователя"});
	ИдентификаторПользователя.Description = "Идентификатор пользователя";
	ИдентификаторПользователя.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ИдентификаторПользователя.GroupName = "";
	ИдентификаторПользователя.Guid = NsgService.StringToGuid("1f78531b-5f7d-481d-8ca9-7281f582dbd2");
	
				if (!ObjectList.Contains("ИдентификаторПользователя"))
                    ObjectList.Add(ИдентификаторПользователя);
			}
			#endregion //создание System.Guid ИдентификаторПользователя
			
			#region создание System.String СистемныйПользователь
			{  
                NsgDataString СистемныйПользователь = null;
				if (ObjectList.Contains("СистемныйПользователь"))
                    СистемныйПользователь = ObjectList["СистемныйПользователь"] as NsgDataString;
                else
                    СистемныйПользователь = new NsgDataString();
	//NsgDataString
	СистемныйПользователь.IsLoadedFromDll = true;
	СистемныйПользователь.Length = 50;
	СистемныйПользователь.StringFormat = "";
	СистемныйПользователь.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	СистемныйПользователь.IncludeInPredefined = false;
	СистемныйПользователь.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	СистемныйПользователь.Required = false;
	СистемныйПользователь.EmptyValue = "";
	СистемныйПользователь.NullAllow = false;
	СистемныйПользователь.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	СистемныйПользователь.FieldName = "_SystemUser";
	СистемныйПользователь.SaveInDatabase = true;
	СистемныйПользователь.InformMetaDataOnValueChanged = false;
	СистемныйПользователь.Visible = true;
	СистемныйПользователь.Name = "СистемныйПользователь";
	СистемныйПользователь.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Системный пользователь"});
	СистемныйПользователь.Description = "Системный пользователь";
	СистемныйПользователь.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	СистемныйПользователь.GroupName = "";
	СистемныйПользователь.Guid = NsgService.StringToGuid("ba0abaa0-3bfd-4628-acbd-e0d9aef67ed4");
	
				if (!ObjectList.Contains("СистемныйПользователь"))
                    ObjectList.Add(СистемныйПользователь);
			}
			#endregion //создание System.String СистемныйПользователь
			
			#region создание System.String Компьютер
			{  
                NsgDataString Компьютер = null;
				if (ObjectList.Contains("Компьютер"))
                    Компьютер = ObjectList["Компьютер"] as NsgDataString;
                else
                    Компьютер = new NsgDataString();
	//NsgDataString
	Компьютер.IsLoadedFromDll = true;
	Компьютер.Length = 50;
	Компьютер.StringFormat = "";
	Компьютер.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Компьютер.IncludeInPredefined = false;
	Компьютер.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Компьютер.Required = false;
	Компьютер.EmptyValue = "";
	Компьютер.NullAllow = false;
	Компьютер.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Компьютер.FieldName = "_Computer";
	Компьютер.SaveInDatabase = true;
	Компьютер.InformMetaDataOnValueChanged = false;
	Компьютер.Visible = true;
	Компьютер.Name = "Компьютер";
	Компьютер.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Компьютер"});
	Компьютер.Description = "Компьютер";
	Компьютер.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Компьютер.GroupName = "";
	Компьютер.Guid = NsgService.StringToGuid("4e93c231-9a5b-4579-a7a4-bb59c566a677");
	
				if (!ObjectList.Contains("Компьютер"))
                    ObjectList.Add(Компьютер);
			}
			#endregion //создание System.String Компьютер
			
			#region создание System.String Событие
			{  
                NsgDataString Событие = null;
				if (ObjectList.Contains("Событие"))
                    Событие = ObjectList["Событие"] as NsgDataString;
                else
                    Событие = new NsgDataString();
	//NsgDataString
	Событие.IsLoadedFromDll = true;
	Событие.Length = 300;
	Событие.StringFormat = "";
	Событие.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Событие.IncludeInPredefined = false;
	Событие.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Событие.Required = false;
	Событие.EmptyValue = "";
	Событие.NullAllow = false;
	Событие.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Событие.FieldName = "_Event";
	Событие.SaveInDatabase = true;
	Событие.InformMetaDataOnValueChanged = false;
	Событие.Visible = true;
	Событие.Name = "Событие";
	Событие.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Событие"});
	Событие.Description = "Событие";
	Событие.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Событие.GroupName = "";
	Событие.Guid = NsgService.StringToGuid("9d84948f-20ce-4192-8d65-bd8f1d0ef6a7");
	
				if (!ObjectList.Contains("Событие"))
                    ObjectList.Add(Событие);
			}
			#endregion //создание System.String Событие
			
			#region создание System.String Комментарий
			{  
                NsgDataString Комментарий = null;
				if (ObjectList.Contains("Комментарий"))
                    Комментарий = ObjectList["Комментарий"] as NsgDataString;
                else
                    Комментарий = new NsgDataString();
	//NsgDataString
	Комментарий.IsLoadedFromDll = true;
	Комментарий.Length = 300;
	Комментарий.StringFormat = "";
	Комментарий.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Комментарий.IncludeInPredefined = false;
	Комментарий.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Комментарий.Required = false;
	Комментарий.EmptyValue = "";
	Комментарий.NullAllow = false;
	Комментарий.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Комментарий.FieldName = "_Comment";
	Комментарий.SaveInDatabase = true;
	Комментарий.InformMetaDataOnValueChanged = false;
	Комментарий.Visible = true;
	Комментарий.Name = "Комментарий";
	Комментарий.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Комментарий"});
	Комментарий.Description = "Комментарий";
	Комментарий.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Комментарий.GroupName = "";
	Комментарий.Guid = NsgService.StringToGuid("8ac7d4ef-65bf-4b75-b7f3-abf3d34393a1");
	
				if (!ObjectList.Contains("Комментарий"))
                    ObjectList.Add(Комментарий);
			}
			#endregion //создание System.String Комментарий
			
			#region создание System.Guid ИдентификаторОбъекта
			{  
                NsgDataGuid ИдентификаторОбъекта = null;
				if (ObjectList.Contains("ИдентификаторОбъекта"))
                    ИдентификаторОбъекта = ObjectList["ИдентификаторОбъекта"] as NsgDataGuid;
                else
                    ИдентификаторОбъекта = new NsgDataGuid();
	//NsgDataGuid
	ИдентификаторОбъекта.IsLoadedFromDll = true;
	ИдентификаторОбъекта.StringFormat = "";
	ИдентификаторОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ИдентификаторОбъекта.IncludeInPredefined = false;
	ИдентификаторОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ИдентификаторОбъекта.Required = false;
	ИдентификаторОбъекта.EmptyValue = "";
	ИдентификаторОбъекта.NullAllow = false;
	ИдентификаторОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ИдентификаторОбъекта.FieldName = "_ObjectID";
	ИдентификаторОбъекта.SaveInDatabase = true;
	ИдентификаторОбъекта.InformMetaDataOnValueChanged = false;
	ИдентификаторОбъекта.Visible = true;
	ИдентификаторОбъекта.Name = "ИдентификаторОбъекта";
	ИдентификаторОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Идентификатор объекта"});
	ИдентификаторОбъекта.Description = "Идентификатор объекта";
	ИдентификаторОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ИдентификаторОбъекта.GroupName = "";
	ИдентификаторОбъекта.Guid = NsgService.StringToGuid("c4887b64-2926-4acb-98d6-4662def64c39");
	
				if (!ObjectList.Contains("ИдентификаторОбъекта"))
                    ObjectList.Add(ИдентификаторОбъекта);
			}
			#endregion //создание System.Guid ИдентификаторОбъекта
			
			#region создание System.String ПолноеИмяОбъекта
			{  
                NsgDataString ПолноеИмяОбъекта = null;
				if (ObjectList.Contains("ПолноеИмяОбъекта"))
                    ПолноеИмяОбъекта = ObjectList["ПолноеИмяОбъекта"] as NsgDataString;
                else
                    ПолноеИмяОбъекта = new NsgDataString();
	//NsgDataString
	ПолноеИмяОбъекта.IsLoadedFromDll = true;
	ПолноеИмяОбъекта.Length = 100;
	ПолноеИмяОбъекта.StringFormat = "";
	ПолноеИмяОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПолноеИмяОбъекта.IncludeInPredefined = false;
	ПолноеИмяОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПолноеИмяОбъекта.Required = false;
	ПолноеИмяОбъекта.EmptyValue = "";
	ПолноеИмяОбъекта.NullAllow = false;
	ПолноеИмяОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ПолноеИмяОбъекта.FieldName = "_ObjectFullname";
	ПолноеИмяОбъекта.SaveInDatabase = true;
	ПолноеИмяОбъекта.InformMetaDataOnValueChanged = false;
	ПолноеИмяОбъекта.Visible = true;
	ПолноеИмяОбъекта.Name = "ПолноеИмяОбъекта";
	ПолноеИмяОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Полное имя объекта"});
	ПолноеИмяОбъекта.Description = "Полное имя объекта";
	ПолноеИмяОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПолноеИмяОбъекта.GroupName = "";
	ПолноеИмяОбъекта.Guid = NsgService.StringToGuid("cec097b8-c616-4986-9393-6d8fd3c1aa02");
	
				if (!ObjectList.Contains("ПолноеИмяОбъекта"))
                    ObjectList.Add(ПолноеИмяОбъекта);
			}
			#endregion //создание System.String ПолноеИмяОбъекта
			
			#region создание System.String ГруппаОбъекта
			{  
                NsgDataString ГруппаОбъекта = null;
				if (ObjectList.Contains("ГруппаОбъекта"))
                    ГруппаОбъекта = ObjectList["ГруппаОбъекта"] as NsgDataString;
                else
                    ГруппаОбъекта = new NsgDataString();
	//NsgDataString
	ГруппаОбъекта.IsLoadedFromDll = true;
	ГруппаОбъекта.Length = 100;
	ГруппаОбъекта.StringFormat = "";
	ГруппаОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ГруппаОбъекта.IncludeInPredefined = false;
	ГруппаОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ГруппаОбъекта.Required = false;
	ГруппаОбъекта.EmptyValue = "";
	ГруппаОбъекта.NullAllow = false;
	ГруппаОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ГруппаОбъекта.FieldName = "_ObjectGroup";
	ГруппаОбъекта.SaveInDatabase = true;
	ГруппаОбъекта.InformMetaDataOnValueChanged = false;
	ГруппаОбъекта.Visible = true;
	ГруппаОбъекта.Name = "ГруппаОбъекта";
	ГруппаОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Группа объекта"});
	ГруппаОбъекта.Description = "Группа объекта";
	ГруппаОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ГруппаОбъекта.GroupName = "";
	ГруппаОбъекта.Guid = NsgService.StringToGuid("68024134-2c37-4314-a12d-b747b3bb7f54");
	
				if (!ObjectList.Contains("ГруппаОбъекта"))
                    ObjectList.Add(ГруппаОбъекта);
			}
			#endregion //создание System.String ГруппаОбъекта
			
			#region создание System.String ПредставлениеОбъекта
			{  
                NsgDataString ПредставлениеОбъекта = null;
				if (ObjectList.Contains("ПредставлениеОбъекта"))
                    ПредставлениеОбъекта = ObjectList["ПредставлениеОбъекта"] as NsgDataString;
                else
                    ПредставлениеОбъекта = new NsgDataString();
	//NsgDataString
	ПредставлениеОбъекта.IsLoadedFromDll = true;
	ПредставлениеОбъекта.Length = 100;
	ПредставлениеОбъекта.StringFormat = "";
	ПредставлениеОбъекта.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	ПредставлениеОбъекта.IncludeInPredefined = false;
	ПредставлениеОбъекта.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ПредставлениеОбъекта.Required = false;
	ПредставлениеОбъекта.EmptyValue = "";
	ПредставлениеОбъекта.NullAllow = false;
	ПредставлениеОбъекта.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	ПредставлениеОбъекта.FieldName = "_ObjectPresentation";
	ПредставлениеОбъекта.SaveInDatabase = true;
	ПредставлениеОбъекта.InformMetaDataOnValueChanged = false;
	ПредставлениеОбъекта.Visible = true;
	ПредставлениеОбъекта.Name = "ПредставлениеОбъекта";
	ПредставлениеОбъекта.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Представление объекта"});
	ПредставлениеОбъекта.Description = "Представление объекта";
	ПредставлениеОбъекта.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ПредставлениеОбъекта.GroupName = "";
	ПредставлениеОбъекта.Guid = NsgService.StringToGuid("46bd9457-f623-4847-bf9e-12d3337f1845");
	
				if (!ObjectList.Contains("ПредставлениеОбъекта"))
                    ObjectList.Add(ПредставлениеОбъекта);
			}
			#endregion //создание System.String ПредставлениеОбъекта
			
			#region создание System.String Данные
			{  
                NsgDataString Данные = null;
				if (ObjectList.Contains("Данные"))
                    Данные = ObjectList["Данные"] as NsgDataString;
                else
                    Данные = new NsgDataString();
	//NsgDataString
	Данные.IsLoadedFromDll = true;
	Данные.Length = 100;
	Данные.StringFormat = "";
	Данные.SubType = NsgSoft.Common.NsgRekvisitSubType.Common;
	Данные.IncludeInPredefined = false;
	Данные.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	Данные.Required = false;
	Данные.EmptyValue = "";
	Данные.NullAllow = false;
	Данные.IndexType = NsgSoft.Database.NsgRekvisitIndexType.Sort;
	Данные.FieldName = "_Data";
	Данные.SaveInDatabase = true;
	Данные.InformMetaDataOnValueChanged = false;
	Данные.Visible = true;
	Данные.Name = "Данные";
	Данные.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Данные"});
	Данные.Description = "Данные";
	Данные.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	Данные.GroupName = "";
	Данные.Guid = NsgService.StringToGuid("c80c4ffa-590b-4629-8baa-5c359034dfc7");
	
				if (!ObjectList.Contains("Данные"))
                    ObjectList.Add(Данные);
			}
			#endregion //создание System.String Данные
			
			#region создание NsgSoft.Forms.NsgRegistrationListForm ФормаСписка
			{  
                NsgDataForm ФормаСписка = null;
				if (ObjectList.Contains("ФормаСписка"))
                    ФормаСписка = ObjectList["ФормаСписка"] as NsgDataForm;
                else
                    ФормаСписка = new NsgDataForm();
	//NsgDataForm
	ФормаСписка.IsLoadedFromDll = true;
	ФормаСписка.FormClassName = "NsgSoft.Forms.NsgRegistrationListForm";
	ФормаСписка.SaveInDatabase = false;
	ФормаСписка.StringFormat = "";
	ФормаСписка.SubType = NsgSoft.Common.NsgRekvisitSubType.ListForm;
	ФормаСписка.IncludeInPredefined = false;
	ФормаСписка.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФормаСписка.Required = false;
	ФормаСписка.EmptyValue = "";
	ФормаСписка.NullAllow = false;
	ФормаСписка.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФормаСписка.FieldName = "FormaSpiska";
	ФормаСписка.InformMetaDataOnValueChanged = false;
	ФормаСписка.Visible = true;
	ФормаСписка.Name = "ФормаСписка";
	ФормаСписка.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФормаСписка.Description = "Форма списка";
	ФормаСписка.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ФормаСписка.GroupName = "";
	ФормаСписка.Guid = NsgService.StringToGuid("36bca4c0-932b-446d-90a4-08c28d36b863");
	
				if (!ObjectList.Contains("ФормаСписка"))
                    ObjectList.Add(ФормаСписка);
			}
			#endregion //создание NsgSoft.Forms.NsgRegistrationListForm ФормаСписка
			
			#region создание NsgSoft.Forms.NsgRegistrationElemForm ФормаЭлемента
			{  
                NsgDataForm ФормаЭлемента = null;
				if (ObjectList.Contains("ФормаЭлемента"))
                    ФормаЭлемента = ObjectList["ФормаЭлемента"] as NsgDataForm;
                else
                    ФормаЭлемента = new NsgDataForm();
	//NsgDataForm
	ФормаЭлемента.IsLoadedFromDll = true;
	ФормаЭлемента.FormClassName = "NsgSoft.Forms.NsgRegistrationElemForm";
	ФормаЭлемента.SaveInDatabase = false;
	ФормаЭлемента.StringFormat = "";
	ФормаЭлемента.SubType = NsgSoft.Common.NsgRekvisitSubType.ElementForm;
	ФормаЭлемента.IncludeInPredefined = false;
	ФормаЭлемента.PeriodicType = NsgSoft.Database.PeriodicTypes.None;
	ФормаЭлемента.Required = false;
	ФормаЭлемента.EmptyValue = "";
	ФормаЭлемента.NullAllow = false;
	ФормаЭлемента.IndexType = NsgSoft.Database.NsgRekvisitIndexType.None;
	ФормаЭлемента.FieldName = "FormaEHlementa";
	ФормаЭлемента.InformMetaDataOnValueChanged = false;
	ФормаЭлемента.Visible = true;
	ФормаЭлемента.Name = "ФормаЭлемента";
	ФормаЭлемента.Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{""});
	ФормаЭлемента.Description = "Форма элемента";
	ФормаЭлемента.EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	ФормаЭлемента.GroupName = "";
	ФормаЭлемента.Guid = NsgService.StringToGuid("11d8d4ee-b441-47b5-8f2b-a68baa4953e7");
	
				if (!ObjectList.Contains("ФормаЭлемента"))
                    ObjectList.Add(ФормаЭлемента);
			}
			#endregion //создание NsgSoft.Forms.NsgRegistrationElemForm ФормаЭлемента
			

			#region заполнение полей класса
				//NsgDataRegistrationJournal
	IsLoadedFromDll = true;
	Name = "ДействияПользователей";
	Visible = true;
	Guid = NsgService.StringToGuid("e001598f-6f00-430d-9056-cd84fd4011d2");
	DefaultSortingName = "";
	DefaultElementFormName = "";
	DefaultListFormName = "";
	ValueMask = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"{Представление}"});
	SearchType = NsgSoft.Database.NsgComparison.Contain;
	SearchFieldName = "";
	DatabaseName = "";
	VisibleAdminOnly = false;
	TableName = "RegistrationJournal";
	Presentation = new NsgSoft.DataObjects.NsgLanguageString(new System.String[]{"(Default)"},
		 new System.Object[]{"Действия пользователей"});
	Description = "Действия пользователей";
	EditorVisible = NsgSoft.DataObjects.NsgDataObjectEditorAccess.Limited;
	GroupName = "Сервис";
	
			#endregion //заполнение полей класса
			#region окончание инициализации NsgSoft.DataObjects.NsgDataRegistrationJournal
			




			#endregion //окончание инициализации NsgSoft.DataObjects.NsgDataRegistrationJournal

			#region необходимые операции после создания реквизитов и заполнения полей
			// внести в кэш полей
            initFieldsCash();
			#endregion //необходимые операции после создания реквизитов и заполнения полей
		}

        #endregion // Инициализация

        #region Имена
        public new partial class Names// :NsgSoft.DataObjects.NsgDataRegistrationJournal.Names
        {
            
            /// <summary>
            /// Идентификатор
            /// </summary>
            public static String Идентификатор
            {
                get
                {
                    return "Идентификатор";
                }
            }
            
            /// <summary>
            /// Автоинкремент
            /// </summary>
            public static String Автоинкремент
            {
                get
                {
                    return "Автоинкремент";
                }
            }
            
            /// <summary>
            /// Дата и время
            /// </summary>
            public static String ДатаВремя
            {
                get
                {
                    return "ДатаВремя";
                }
            }
            
            /// <summary>
            /// Пользователь
            /// </summary>
            public static String Пользователь
            {
                get
                {
                    return "Пользователь";
                }
            }
            
            /// <summary>
            /// Идентификатор пользователя
            /// </summary>
            public static String ИдентификаторПользователя
            {
                get
                {
                    return "ИдентификаторПользователя";
                }
            }
            
            /// <summary>
            /// Системный пользователь
            /// </summary>
            public static String СистемныйПользователь
            {
                get
                {
                    return "СистемныйПользователь";
                }
            }
            
            /// <summary>
            /// Компьютер
            /// </summary>
            public static String Компьютер
            {
                get
                {
                    return "Компьютер";
                }
            }
            
            /// <summary>
            /// Событие
            /// </summary>
            public static String Событие
            {
                get
                {
                    return "Событие";
                }
            }
            
            /// <summary>
            /// Комментарий
            /// </summary>
            public static String Комментарий
            {
                get
                {
                    return "Комментарий";
                }
            }
            
            /// <summary>
            /// Идентификатор объекта
            /// </summary>
            public static String ИдентификаторОбъекта
            {
                get
                {
                    return "ИдентификаторОбъекта";
                }
            }
            
            /// <summary>
            /// Полное имя объекта
            /// </summary>
            public static String ПолноеИмяОбъекта
            {
                get
                {
                    return "ПолноеИмяОбъекта";
                }
            }
            
            /// <summary>
            /// Группа объекта
            /// </summary>
            public static String ГруппаОбъекта
            {
                get
                {
                    return "ГруппаОбъекта";
                }
            }
            
            /// <summary>
            /// Представление объекта
            /// </summary>
            public static String ПредставлениеОбъекта
            {
                get
                {
                    return "ПредставлениеОбъекта";
                }
            }
            
            /// <summary>
            /// Данные
            /// </summary>
            public static String Данные
            {
                get
                {
                    return "Данные";
                }
            }
            
            /// <summary>
            /// Форма списка
            /// </summary>
            public static String ФормаСписка
            {
                get
                {
                    return "ФормаСписка";
                }
            }
            
            /// <summary>
            /// Форма элемента
            /// </summary>
            public static String ФормаЭлемента
            {
                get
                {
                    return "ФормаЭлемента";
                }
            }
            
        }

        #endregion // Имена

        #region Свойства
        public override NsgMultipleObjectDescriptor Descriptor
        {
            get
            {
                if (descriptor == null)
                {
                    descriptor = new NsgMultipleObjectDescriptor();
                    descriptor.Name = "ДействияПользователей";
                    descriptor.GroupName = "Сервис";
                }
                return descriptor;
            }
            set
            {
            }
        }


        public static string GetFullName()
        {
            return "Сервис.ДействияПользователей";
        }

        
        /// <summary>
        /// Идентификатор
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid Идентификатор
        {
            get
            {
				 NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                 return (System.Guid)__Идентификатор.Value;
            }
            set
            {
                NsgDataGuid __Идентификатор = ObjectList["Идентификатор"] as NsgDataGuid;
                __Идентификатор.Value = value;
            }
        }
        
        /// <summary>
        /// Автоинкремент
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataInteger")]
        
        public System.Int64 Автоинкремент
        {
            get
            {
				 NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                 return (System.Int64)__Автоинкремент.Value;
            }
            set
            {
                NsgDataInteger __Автоинкремент = ObjectList["Автоинкремент"] as NsgDataInteger;
                __Автоинкремент.Value = value;
            }
        }
        
        /// <summary>
        /// Дата и время
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataDateTime")]
        
        public System.DateTime ДатаВремя
        {
            get
            {
				 NsgDataDateTime __ДатаВремя = ObjectList["ДатаВремя"] as NsgDataDateTime;
                 return (System.DateTime)__ДатаВремя.Value;
            }
            set
            {
                NsgDataDateTime __ДатаВремя = ObjectList["ДатаВремя"] as NsgDataDateTime;
                __ДатаВремя.Value = value;
            }
        }
        
        /// <summary>
        /// Пользователь
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Пользователь
        {
            get
            {
				 NsgDataString __Пользователь = ObjectList["Пользователь"] as NsgDataString;
                 return (System.String)__Пользователь.Value;
            }
            set
            {
                NsgDataString __Пользователь = ObjectList["Пользователь"] as NsgDataString;
                __Пользователь.Value = value;
            }
        }
        
        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid ИдентификаторПользователя
        {
            get
            {
				 NsgDataGuid __ИдентификаторПользователя = ObjectList["ИдентификаторПользователя"] as NsgDataGuid;
                 return (System.Guid)__ИдентификаторПользователя.Value;
            }
            set
            {
                NsgDataGuid __ИдентификаторПользователя = ObjectList["ИдентификаторПользователя"] as NsgDataGuid;
                __ИдентификаторПользователя.Value = value;
            }
        }
        
        /// <summary>
        /// Системный пользователь
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String СистемныйПользователь
        {
            get
            {
				 NsgDataString __СистемныйПользователь = ObjectList["СистемныйПользователь"] as NsgDataString;
                 return (System.String)__СистемныйПользователь.Value;
            }
            set
            {
                NsgDataString __СистемныйПользователь = ObjectList["СистемныйПользователь"] as NsgDataString;
                __СистемныйПользователь.Value = value;
            }
        }
        
        /// <summary>
        /// Компьютер
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Компьютер
        {
            get
            {
				 NsgDataString __Компьютер = ObjectList["Компьютер"] as NsgDataString;
                 return (System.String)__Компьютер.Value;
            }
            set
            {
                NsgDataString __Компьютер = ObjectList["Компьютер"] as NsgDataString;
                __Компьютер.Value = value;
            }
        }
        
        /// <summary>
        /// Событие
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Событие
        {
            get
            {
				 NsgDataString __Событие = ObjectList["Событие"] as NsgDataString;
                 return (System.String)__Событие.Value;
            }
            set
            {
                NsgDataString __Событие = ObjectList["Событие"] as NsgDataString;
                __Событие.Value = value;
            }
        }
        
        /// <summary>
        /// Комментарий
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Комментарий
        {
            get
            {
				 NsgDataString __Комментарий = ObjectList["Комментарий"] as NsgDataString;
                 return (System.String)__Комментарий.Value;
            }
            set
            {
                NsgDataString __Комментарий = ObjectList["Комментарий"] as NsgDataString;
                __Комментарий.Value = value;
            }
        }
        
        /// <summary>
        /// Идентификатор объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataGuid")]
        
        public System.Guid ИдентификаторОбъекта
        {
            get
            {
				 NsgDataGuid __ИдентификаторОбъекта = ObjectList["ИдентификаторОбъекта"] as NsgDataGuid;
                 return (System.Guid)__ИдентификаторОбъекта.Value;
            }
            set
            {
                NsgDataGuid __ИдентификаторОбъекта = ObjectList["ИдентификаторОбъекта"] as NsgDataGuid;
                __ИдентификаторОбъекта.Value = value;
            }
        }
        
        /// <summary>
        /// Полное имя объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ПолноеИмяОбъекта
        {
            get
            {
				 NsgDataString __ПолноеИмяОбъекта = ObjectList["ПолноеИмяОбъекта"] as NsgDataString;
                 return (System.String)__ПолноеИмяОбъекта.Value;
            }
            set
            {
                NsgDataString __ПолноеИмяОбъекта = ObjectList["ПолноеИмяОбъекта"] as NsgDataString;
                __ПолноеИмяОбъекта.Value = value;
            }
        }
        
        /// <summary>
        /// Группа объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ГруппаОбъекта
        {
            get
            {
				 NsgDataString __ГруппаОбъекта = ObjectList["ГруппаОбъекта"] as NsgDataString;
                 return (System.String)__ГруппаОбъекта.Value;
            }
            set
            {
                NsgDataString __ГруппаОбъекта = ObjectList["ГруппаОбъекта"] as NsgDataString;
                __ГруппаОбъекта.Value = value;
            }
        }
        
        /// <summary>
        /// Представление объекта
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String ПредставлениеОбъекта
        {
            get
            {
				 NsgDataString __ПредставлениеОбъекта = ObjectList["ПредставлениеОбъекта"] as NsgDataString;
                 return (System.String)__ПредставлениеОбъекта.Value;
            }
            set
            {
                NsgDataString __ПредставлениеОбъекта = ObjectList["ПредставлениеОбъекта"] as NsgDataString;
                __ПредставлениеОбъекта.Value = value;
            }
        }
        
        /// <summary>
        /// Данные
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataString")]
        
        public System.String Данные
        {
            get
            {
				 NsgDataString __Данные = ObjectList["Данные"] as NsgDataString;
                 return (System.String)__Данные.Value;
            }
            set
            {
                NsgDataString __Данные = ObjectList["Данные"] as NsgDataString;
                __Данные.Value = value;
            }
        }
        

        
        /// <summary>
        /// Форма списка
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm ФормаСписка
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["ФормаСписка"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"ФормаСписка");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"ФормаСписка");
                return res;
           }
        }
        
        /// <summary>
        /// Форма элемента
        /// </summary>
        [NsgView(NsgViewTypes.DesignTime)]
        [NsgTypeName("NsgDataForm")]
        
        public INsgObjectForm ФормаЭлемента
        {
            get
            {
                INsgObjectForm res = null;
                if (ObjectList["ФормаЭлемента"].SubType == NsgRekvisitSubType.ListForm)
                   res = NsgSettings.MainForm.GetObjectListForm(this,"ФормаЭлемента");
                else
                   res = NsgSettings.MainForm.GetObjectForm(this,"ФормаЭлемента");
                return res;
           }
        }
        
        #region Свойства NsgSoft.DataObjects.NsgDataRegistrationJournal
        


        protected static NsgMultipleObjectDescriptor descriptor = null;
        


        #endregion // Свойства NsgSoft.DataObjects.NsgDataRegistrationJournal

        #endregion // Свойства

        #region Методы
        #region Методы NsgSoft.DataObjects.NsgDataRegistrationJournal
        




        #endregion // Методы NsgSoft.DataObjects.NsgDataRegistrationJournal

        #region Методы NsgMultipleObject
        private ДействияПользователей[] convertArray(NsgMultipleObject[] array)
        {
            ДействияПользователей[] res = new ДействияПользователей[array.Length];
            array.CopyTo(res, 0);
            return res;
        }


        #region Поиск множества результатов на полное совпадение. Перегруженные методы.
        /// <summary>
        /// Метод поиска в БД по одному и более реквизитов с ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        /// </remarks>
        /// <param name="compare">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ДействияПользователей[] FindAll(NsgCompare compare)
        {
            return convertArray(base.FindAll(compare));
        }

        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному и более реквизитов
        ///  c ограничением количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="paramAll">Параметры запроса.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ДействияПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgCompare compare)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, compare));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Имя реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ДействияПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, string inName, object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }


        /// <summary>
        /// Метод поиска в БД на полное совпадение по одному реквизиту c ограничением 
        ///  количества результатов.
        /// </summary>
        /// <remarks>
        /// Результатом являются все строки, удовлетворяющие критериям поиска,
        ///  но не более заданного предела.
        /// </remarks>
        /// <param name="count">Ограничение на количество объектов в результате.</param>
        /// <param name="sorting">Параметры сортировки.</param>
        /// <param name="inName">Идентификатор реквизита.</param>
        /// <param name="inValue">Значение для поиска. Условие поиска - полное совпадение.</param>
        /// <returns>Список найденных объектов.</returns>
        public new virtual ДействияПользователей[] FindAll(ref int count, Int64 row_start, NsgSorting sorting, NsgDataFixedFields inName,
            object inValue)
        {
            return convertArray(base.FindAll(ref count, row_start, sorting, inName, inValue));
        }
        #endregion Поиск множества результатов на полное совпадение. Перегруженные методы.

        public override NsgObject CloneObject
        {
            get
            {
                return new ДействияПользователей(this as NsgObject);
            }
        }

        #endregion // Методы NsgMultipleObject
        #endregion // Методы

        /// <summary>
        /// Описатель колонки источника данных
        /// </summary>
        public new class ColumnDescriptor : NsgSoft.Forms.NsgColumnDescriptor
        {
            public ColumnDescriptor()
                : base()
            {
                base.NSGType = typeof(ДействияПользователей);
            }

			/// <summary>
            /// Значение для текущей строки
			/// </summary>
			[Browsable(false)]
			[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
			public new ДействияПользователей Value
            {
                get
                {
                    return (ДействияПользователей)base.Value;
                }
                set
                {
                    base.Value = value;
                }
            }

            /// <summary>
            /// Имя иконки колонки
            /// </summary>
            public override string ImageKey
            {
                get
                {
                    return "s_NsgDataRegistrationJournal";
                }
            }
        }

    }

}
