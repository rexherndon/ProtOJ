using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProtOJ.Models
{
    public class User
    {
        public int    ID                {get; set;}                       // PK
        public string FirstName         {get; set;}
        public string LastName          {get; set;}
        public string Email             {get; set;}                      // Used for IF
        public string Address           {get; set;}
        public int    PhoneNumber       {get; set;}
        public string Username          {get; set;}
        public string Password          {get; set;}
        public bool   IsStudentAdvisor  {get; set;}
        public bool   IsSpeaker         {get; set;}
        public ICollection<Session> Sessions       {get; set;}

    }
}