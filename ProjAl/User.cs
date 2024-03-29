﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Configuration;
using System.Dynamic;

namespace ProjAl
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }

        string query;

        public List<User> ReadAll()
        {
            query = "Select * from dbo.[User] u";
            using (var connection = new SqlConnection(Configcs.ConnectionString))
            {
                var users = connection.Query<User>(query).ToList();
                return users;
            }


        }

        public User GetUser(string usr, string pwd)
        {
            using (var db = new SqlConnection(Configcs.ConnectionString))
            {
                try
                    {
                        var user = db.Query<User>("Select * From dbo.[User] u WHERE username = @username and password = @password", new { username = usr, password = pwd }).First();
                        return user;
                    }
                 catch (Exception e)
                    {
                        return null;
                    }
             }
        }

    }
}
