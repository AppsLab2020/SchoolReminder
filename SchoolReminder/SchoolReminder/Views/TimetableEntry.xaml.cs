using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using System.IO;

namespace SchoolReminder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }



        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            var entries = new Entries();
            entries.Pon1 = Pon1.Text;
            entries.Pon2 = Pon2.Text;
            entries.Pon3 = Pon3.Text;
            entries.Pon4 = Pon4.Text;
            entries.Pon5 = Pon5.Text;
            entries.Pon6 = Pon6.Text;
            entries.Pon7 = Pon7.Text;
            entries.Ut1 = Ut1.Text;
            entries.Ut2 = Ut2.Text;
            entries.Ut3 = Ut3.Text;
            entries.Ut4 = Ut4.Text;
            entries.Ut5 = Ut5.Text;
            entries.Ut6 = Ut6.Text;
            entries.Ut7 = Ut7.Text;
            entries.Str1 = Str1.Text;
            entries.Str2 = Str2.Text;
            entries.Str3 = Str3.Text;
            entries.Str4 = Str4.Text;
            entries.Str5 = Str5.Text;
            entries.Str6 = Str6.Text;
            entries.Str7 = Str7.Text;
            entries.Stv1 = Stv1.Text;
            entries.Stv2 = Stv2.Text;
            entries.Stv3 = Stv3.Text;
            entries.Stv4 = Stv4.Text;
            entries.Stv5 = Stv5.Text;
            entries.Stv6 = Stv6.Text;
            entries.Stv7 = Stv7.Text;
            entries.Pia1 = Pia1.Text;
            entries.Pia2 = Pia2.Text;
            entries.Pia3 = Pia3.Text;
            entries.Pia4 = Pia4.Text;
            entries.Pia5 = Pia5.Text;
            entries.Pia6 = Pia6.Text;
            entries.Pia7 = Pia7.Text;

           
         ///   using var conn = new SQLiteConnection(Path.Combine(App.FilePath, "rozvrh_db.db3")); 
     ///       conn.CreateTable<Entries>();


        }
    }
}