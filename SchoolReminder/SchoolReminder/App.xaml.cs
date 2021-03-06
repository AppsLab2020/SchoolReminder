﻿using SchoolReminder.Services;
using SchoolReminder.Repository;
using SchoolReminder.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SchoolReminder.Models;
using Xamarin.Essentials;

namespace SchoolReminder
{
    public partial class App : Application

    {

        public JulianDate FirstDate { get; }
        public JulianDate LastDate { get; }


        public JulianDate[,] array { get; set; }

        public JulianDate selected { get; set; }

        public Int32 monthI { get; set; }
        public Int32 yearI { get; set; }

        public CalendarValue calendarValue { get; set; }

        public CalendarPage calendarPage { get; set; }

        public ListPage listPage { get; set; }


        public Color MainTextColor { get; }

        public Color DisabledTextColor { get; }
        public Color DividerColor { get; }
        public Color OtherMonthColor { get; }
        public Color TitleBarColor { get; }
        public Color OddRowColor { get; }
        public Color EvenRowColor { get; }
        public Color DecYearColor { get; }
        public Color DoyColor { get; }
        public Color MjdColor { get; }
        public Color SelectedColor { get; }

        public const string DATABASE_NAME = "notes.db";
        public static NoteRepository database;

        public static NoteRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new NoteRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }

        public App()
        {
            InitializeComponent();

            FirstDate = JulianDate.FromCalendarDate(1859, 1, 1);
            LastDate = JulianDate.FromCalendarDate(3859, 12, 31);

            Int32 mjd = Preferences.Get("MJD", -2400000);
            calendarValue = (CalendarValue)Enum.Parse(
                typeof(CalendarValue),
                Preferences.Get("Value", CalendarValue.Day_Of_Year.ToString()));

            selected = (mjd > -2399990) ? JulianDate.FromMJD(mjd) : JulianDate.Now();
            monthI = selected.Month;
            yearI = selected.Year;
            CalcArray();

            MainTextColor = (Color)Resources["MainTextColor"];
            DisabledTextColor = (Color)Resources["DisabledTextColor"];
            DividerColor = (Color)Resources["DividerColor"];
            OtherMonthColor = (Color)Resources["OtherMonthColor"];
            TitleBarColor = (Color)Resources["TitleBarColor"];
            OddRowColor = (Color)Resources["OddRowColor"];
            EvenRowColor = (Color)Resources["EvenRowColor"];
            DecYearColor = (Color)Resources["DecYearColor"];
            DoyColor = (Color)Resources["DoyColor"];
            MjdColor = (Color)Resources["MjdColor"];
            SelectedColor = (Color)Resources["SelectedColor"];

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        public Color getTextColor()
        {
            switch (calendarValue)
            {
                case CalendarValue.Day_Of_Year:
                    return DoyColor;

                case CalendarValue.Decimal_Year:
                    return DecYearColor;

                case CalendarValue.Modified_Julian_Date:
                    return MjdColor;

                default:
                    return MjdColor;
            }
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        public void CalcArray()
        {
            array = JulianDate.CalendarMonth(yearI, monthI);
        }

        public void persistSelected(JulianDate selected)
        {
            this.selected = selected;
            Preferences.Set("MJD", selected.MJD);
        }

        public void persistValue(CalendarValue value)
        {
            this.calendarValue = value;
            Preferences.Set("Value", value.ToString());
        }
    }
}