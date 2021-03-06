﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace Iskola.Data
{
    public class NewMark
    {
        public String Value { get; internal set; }
        public String Subject { get; internal set; }
        public String Date { get; internal set; }
        public String Teacher { get; internal set; }
    }
    public class Table
    {
        internal List<HourDefinition> _hourDefinitions = new List<HourDefinition>();
        public List<HourDefinition> HourDefinitions { get { return _hourDefinitions; } }

        internal List<Day> _days = new List<Day>();
        public List<Day> Days
        {
            get { return _days; }
        }
    }
    public class HourDefinition
    {
        public ushort HourNumber { get; internal set; }
        public String FromTo { get; internal set; }
    }
    public class Day
    { 
        public String DayInWeek { get; internal set; }
        public String Date { get; internal set; }

        internal List<Hour> _hours = new List<Hour>();
        public List<Hour> Hours { get { return _hours; } }
        public bool IsFreeDay { get; internal set; } = false;
        public String FreeDayName { get; internal set; } = "";
    }
    public class Hour
    {
        public ushort HourNumber { get; internal set; }
        internal List<Subject> _subjects = new List<Subject>();
        public List<Subject> Subjects { get { return _subjects; } }
    }
    public class Subject
    {
        public SubjectState State { get; internal set; } = SubjectState.Actual;
        public string SubjectName { get; set; }
        public string Teacher { get; internal set; }
        public string Class { get; internal set; }
        public string Placement { get; internal set; }
        public string Title { get; internal set; }
        public bool IsSchoolAction { get; internal set; } = false;
        public string SchoolActionName { get; internal set; } = "";
        public int SchoolActionLenght { get; internal set; } = 0;
    }
    public enum SubjectState
    {
        Canceled,
        Actual
    }
    public class NewsMessage
    {
        public string Date { get; internal set; }
        public string Title { get; internal set; }
        public string Content { get; internal set; }
    }
}
