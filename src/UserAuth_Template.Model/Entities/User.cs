﻿using System;

namespace UserAuth_Template.Model.Entities
{
    public class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
    }
}
