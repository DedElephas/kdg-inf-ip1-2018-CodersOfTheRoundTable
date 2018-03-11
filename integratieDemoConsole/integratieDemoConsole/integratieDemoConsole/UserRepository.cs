﻿using System;
using System.Collections.Generic;
using System.Text;

namespace integratieDemoConsole
{
    class UserRepository
    {
        private List<User> userList;
        private int userCounter;

        public UserRepository()
        {
            userCounter = 0;
            userList = new List<User>();
        }
        public UserRepository(List<User> userList)
        {
            userList = new List<User>();
            this.userList = userList;
            userCounter = userList.Count; // dit klopt niet, als een gebruiker midden weg is gehaald krijgen we overlappingen => dit moet met FindLast op te lossen zijn!
        }

        public void AddUser(String userName)
        {
            userList.Add(new User(userCounter++, userName));
        }

        public User[] GetUsers()
        {
            return userList.ToArray();
        }

        public User GetUser(int registratieId)
        {
            return userList.Find(user => user.registratieId == registratieId);
            
        }
    }
}
