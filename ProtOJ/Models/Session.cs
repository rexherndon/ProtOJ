using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ProtOJ.Models
{
    public class Session
    {
        public int      ID                       {get; set;}                       // PK
        public string   SessionName              {get; set;}
        public DateTime SessionDate              {get; set;}
        public string   CreatedBy                {get; set;}                       // this will be parsed automatically using the "username" of the user logged in.
    
        public ICollection<User> Users       {get; set;}

    }
}