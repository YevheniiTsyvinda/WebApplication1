using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TinyCsvParser.Mapping;

namespace WebApplication1.Models
{
    public class Model
    {
        public string Protocolname { get; set; }
        public string Instrument { get; set; }
        public string Parameter { get; set; }
        public int Level { get; set; }
        public DateTime Date { get; set; }
        public string Value { get; set; }
        public double Target { get; set; }
        public double SD { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }
        public string Usercomment { get; set; }
        public string User { get; set; }
        public string SampleID { get; set; }
    }

    public class ModelClassMap : CsvMapping<Model>
    {
        public ModelClassMap():base()
        {
            MapProperty(0, m => m.Protocolname);
            MapProperty(1, m => m.Instrument);
            MapProperty(2, m => m.Parameter);
            MapProperty(3, m => m.Level);
            MapProperty(4, m => m.Date);//// error
            MapProperty(5, m => m.Value);
            MapProperty(6, m => m.Target);
            MapProperty(7, m => m.SD);
            MapProperty(8, m => m.Status);
            MapProperty(9, m => m.Message);
            MapProperty(10, m => m.Usercomment);
            MapProperty(11, m => m.User);
            MapProperty(12, m => m.SampleID);
        }
        public DateTime ConvertDate(DateTime date)
        {
            var d = DateTime.ParseExact(
            date.ToString(), "ddd MMM dd yyyy HH:mm:ss 'GMT'K '(GMT Standard Time)'",
            CultureInfo.InvariantCulture);
            return d;
        }
       
    }

   
}
