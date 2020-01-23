﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PetGrooming.Models
{
    public class GroomBooking
    {
        /*
            A GroomBooking is an agreement between an owner and a groomer to provide services for a pet
            
            Some things that describe a GroomBooking
                - A date and time
                - Price
            
            A GroomBooking must reference
                - A Groomer
                - A Pet
                - An Owner
                - A list of GroomServices
                
        */
        public int GroomBookingID { get; set; }
        public int PetID { get; set; }
        public int OwnerID { get; set; }
        public int GroomerID { get; set; }
        public int GroomServiceID { get; set; }
        public string GroomServiceDate { get; set; }
        public string GroomServiceTotalPrice { get; set; }
        public string GroomServiceNote { get; set; }
    }
}