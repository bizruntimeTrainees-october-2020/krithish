﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LibraryData.Models
{
   public class Hold
    {
        public int Id { get; set; }
        public LibraryAsset LibraryAsset { get; set; }
        
        public LibraryCard LibraryCard { get; set; }

        public DateTime HoldPlaced { get; set; }
    }
}
