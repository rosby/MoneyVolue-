using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NsgSoft.DataObjects;
using NsgSoft.Forms;
using System.Net;
using System.IO;
using System.Globalization;
using NsgSoft.Database;

namespace Val.Метаданные.Деньги
{
    
    public partial class ЗагрузкаКурсовФорма

    {
        public ЗагрузкаКурсовФорма()
        {
            InitializeComponent();
		}

		#region #Comments_Data# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Data# NsgSoft.Forms.NsgReportForm

		#region #Comments_Constructors# NsgSoft.Forms.NsgReportForm
		
		#endregion //#Comments_Constructors# NsgSoft.Forms.NsgReportForm

		#region #Comments_Methods# NsgSoft.Forms.NsgReportForm
		
        protected override void OnBeforeCreateReport(NsgBackgroundWorker nsgBackgroundReporter)
        {
            base.OnBeforeCreateReport(nsgBackgroundReporter);
        }

        protected override void OnCreateReport(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.DoWorkEventArgs e)
        {
            base.OnCreateReport(nsgBackgroundReporter, e);


            string path = $"{Валюта.Value.Наименование}Value.txt";

            WebClient webload = new WebClient();
            string FileName = "http://cbrates.rbc.ru/tsv/cb/" + $"{Валюта.Value.КодВалюты}.tsv";
            webload.DownloadFile(new Uri(FileName), path);

            StreamReader sr = new StreamReader(path);
            var text = sr.ReadToEnd().Split('\n');

            DateTime DateS = ДатаС.Value;
            DateTime DatePo = ДатаПо.Value;
            var val = Валюта.Value;

            for (int i = 0; i < text.Length; i++)
            {
                var row = text[i].Split('\t');
                DateTime date = DateTime.ParseExact(row[0], "yyyyMMdd", CultureInfo.InvariantCulture);

                var compareFirst = date.CompareTo(DateS);
                var compareSecond = date.CompareTo(DatePo);
                if ((compareFirst == 1 | compareSecond == -1) & (compareFirst == 1 | compareSecond == 0) & (compareFirst == 1 | compareSecond == -1))
                {
                    var history = ИсторияКурсов.Новый();
                    history.New();
                    history.ДатаВремя = date;
                    history.Значение = Math.Round(Convert.ToDecimal(row[2], NumberFormatInfo.InvariantInfo), 2);
                    history.Валюта = val;
                    history.Post();
                }

            }

            var obj = ИсторияКурсов.Новый();

            NsgCompare cmp = new NsgCompare();

            cmp.Add(ИсторияКурсов.Names.Валюта, Валюта.Value.Наименование, NsgComparison.Contain);
            var array = obj.FindAll(cmp);
            var max = array[array.Length - 1];

            NsgCompare cmpSecond = new NsgCompare();
            cmpSecond.Add(Валюты.Names.Наименование, Валюта.Value.Наименование, NsgComparison.Contain);
            var objValue = Валюты.Новый();
            objValue.Find(cmpSecond);
            objValue.Edit();
            objValue.ТекущийКурс = max.Значение;
            objValue.Post();

        }

        protected override void OnCreateReportCompleted(NsgBackgroundWorker nsgBackgroundReporter, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            base.OnCreateReportCompleted(nsgBackgroundReporter, e);

            

        }

        #endregion //#Comments_Methods# NsgSoft.Forms.NsgReportForm

        #region #Comments_Properties# NsgSoft.Forms.NsgReportForm

        #endregion //#Comments_Properties# NsgSoft.Forms.NsgReportForm
    }
    


}