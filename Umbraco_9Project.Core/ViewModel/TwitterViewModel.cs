﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbraco_9Project.Core.ViewModel
{
    public class TwitterViewModel
    {
        public string TwitterHandle { get; set; }
        public bool Error { get; set; }
        public string Json { get; set; }
        public string Message { get; set; }
    }
}
