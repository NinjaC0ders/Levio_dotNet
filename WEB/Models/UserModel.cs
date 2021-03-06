﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WEB.Models
{
    public class UserModel
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Column(TypeName = "bit")]
        public bool archived { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [StringLength(255)]
        public string first_name { get; set; }

        [StringLength(255)]
        public string last_name { get; set; }

        [StringLength(255)]
        public string note { get; set; }

        [StringLength(255)]
        public string password { get; set; }

        [StringLength(255)]
        public string photo { get; set; }

        [StringLength(255)]
        public string role { get; set; }

        [StringLength(255)]
        public string token { get; set; }

    }
}