﻿using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BMIAppXamarin.Data
{
    //This is the table "BMIData"
    public class BMIData
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get; set; }
    }
}
