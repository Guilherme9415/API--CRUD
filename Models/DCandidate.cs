﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models {
    public class DCandidate {

        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100)")] 
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string Telephone { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string  email { get; set; }

        public string age { get; set; }


        [Column(TypeName = "nvarchar(100)")]
        public string address { get; set; }



    }
}