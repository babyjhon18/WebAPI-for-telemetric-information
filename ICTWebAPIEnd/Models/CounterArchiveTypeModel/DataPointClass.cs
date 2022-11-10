﻿using System;
using System.Collections.Generic;

namespace ICTWebAPIEND.Models.CounterArchiveTypeModel
{

    public class DataPointClass
    {
        public DateTime TimeStamp { get; set; }
        public List<FieldsClass> Fields { get; set; }
        public DataPointClass()
        {
            Fields = new List<FieldsClass>();
        }
    }
}