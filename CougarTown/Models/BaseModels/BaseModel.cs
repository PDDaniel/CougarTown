﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CougarTown.Models.BaseModels
{
    public class BaseModel
    {
        public int ID { get; set; }

        // Page Requirements
        public string PageTitle { get; set; }
        public string MetaDescription { get; set; }
    }
}