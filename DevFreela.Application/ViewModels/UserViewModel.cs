﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
    }
}
