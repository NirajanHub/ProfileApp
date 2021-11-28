using System;
using System.Collections.Generic;
using API.Extenseions;

namespace API.Entities
{
    public class AppUser
    {   
        public int Id { get; set; }
        public string UserName { get; set; }     

        public byte[] PasswordHash {get;set;}

        public byte[] PasswordSalt {get;set;}

        public DateTime DateOfBirth{get;set;}

        public string KnownAs{get;set;}


        public System.DateTime Created {get;set;} = DateTime.Now;

        public System.DateTime LastActive {get;set;} = DateTime.Now;

        public string Gender{get;set;}


        public string Introduction{get;set;}


        public string LookingFor{get;set;}


        public string Intrests{get;set;}


        public string City{get;set;}


        public string Country{get;set;}

        public ICollection<Photos> Photos {get;set;}

        
    } 
}