﻿namespace ContactsAPI.Models
{
    public class Contact
    {
        public Guid Id { get; set; }        ///
        public string FullName { get; set; }
        public string EMail { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }


    }
}
