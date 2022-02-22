﻿using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingCenterForms
{
    //openHours: type Hours[7]
    //busyShifts: type
    //mixYears: bool
    //mixMajors: bool
    //perShift: int[2]
    //adjacentShifts: int
    //ScheduleFilled: bool
    internal class Schedule
    {
        public bool scheduleFilled;
        public ArrayList openHours;
        public bool MixYears { get; set; }
        public bool MixMajors { get; set; }
        public string[,] schedule;
        public Dictionary<string, int> days;

        public Schedule()
        {    
            scheduleFilled = false;
            schedule = new string[22,7];
            openHours = new ArrayList();
            days = new Dictionary<string, int>(){
                { "sunday", 0},
                { "monday", 1},
                { "tuesday", 2},
                { "wednesday", 3},
                { "thursday", 4},
                { "friday", 5},
                { "saturday", 6}
            };
            List<string> dayKeys = new List<string>(days.Keys);
            for (int i = 0; i < 7; i++)
            {
                for (int j = 8; j < 22; j++)
                {
                    schedule[j, i] = "--";
                    if (i != 6)
                    {
                        openHours.Add(dayKeys[i] + " " + convertTimeS(j));
                    }
                }
            }
            importCSVFile();
            scheduleFilled = true;
        }

        public void importCSVFile(string fileName = @"schedule_draft.csv")
        {
            string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, @"Data\", fileName);
            var reader = new StreamReader(File.OpenRead(path));
            var line = reader.ReadLine(); //Take out the header
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                if (line != ",," && line != null)    //get rid of the blank lines in the csv file
                {
                    Regex regx = new Regex("," + "(?=(?:[^\"]*\"[^\"]*\")*(?![^\"]*\"))"); //separates by , but leaves , that are inside ""
                    string[] values = regx.Split(line);
                    string time = values[0].Split('y')[1].Split('-')[0];    //has values like 9:00pm
                    string day = values[0].Split('y')[0] + 'y';     //has the value sunday, monday...
                    string workers = values[1].Replace("\'", "").Replace("[", "").Replace("]", ""); //has "Natalie, Alice"...
                    string numOfWorkers = values[2];
                    schedule[convertTime(time), days[day]] = workers;
                    openHours.Remove(day + " " + time);
                }
            }
        }

        public string[,] getSchedule()
        {
            return schedule;
        }

        public ArrayList getOpenHours()
        {
            return openHours;
        }

        private int convertTime(string s)
        {
            int hour = int.Parse(s.Split(':')[0]);
            if (s.EndsWith("pm")) hour = (hour % 12) + 12; //convert 12-hour time to 24-hour
            return hour;
        }

        private string convertTimeS(int i)
        {
            if (i > 12) return i - 12 + ":00pm";
            else if (i < 12) return i + ":00am";
            else return i + ":00pm";
        }

        public string[] getWorkers(int i, int j)
        {

            return schedule[i, j].Split(',');
        }

        public void exportCSV()
        {
            string delimiter = ", ";
            string s = "Time" + delimiter;
            foreach (string day in days.Keys)
            {
                s += day + delimiter;
            }
            s = s.Substring(0, s.Length - 2) + "\n";
            for (int i = 7; i < 24; i++)
            {
                s += i.ToString() + delimiter;
                for (int j = 0; j < 7; j++)
                {
                    s += schedule[i, j].Replace(",", "|") + delimiter;
                }
                s = s.Substring(0, s.Length - 2) + "\n";
            }
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Data\", "schedule.csv");
            File.WriteAllText(path, s);
        }

    }
}
