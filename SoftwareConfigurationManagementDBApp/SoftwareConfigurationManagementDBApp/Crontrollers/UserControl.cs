﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SoftwareConfigurationManagementDBApp
{
    public class UserControl
    {
        private String _connectionstring;

        public UserControl()
        {
          _connectionstring =  ConfigurationManager.ConnectionStrings["SCMDatabaseConnectionString"].ConnectionString;
        }
        public void OpenUserForm(User aUser, int AddUpdate)
        {
            if (AddUpdate == 1)
            {
                aUser = null;
                AddUser aUserForm = new AddUser(this, aUser, 1);
                aUserForm.Show();
            }
            else
            {
                AddUser aUserForm = new AddUser(this, aUser, 2);
                aUserForm.Show();
            }
        }

        public void OpenUserView()
        {
            ViewUsers ViewAllUsers = new ViewUsers(this);
            ViewAllUsers.Show();
        }

        public bool AddUser(User aUser)
        {
            bool result;

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand AddUser = new SqlCommand("usp_Insert_NewUser", conn))
                {
                    try
                    {
                        conn.Open();
                        AddUser.CommandType = CommandType.StoredProcedure;
                        AddUser.Parameters.AddWithValue("@Username", aUser.Username);
                        AddUser.Parameters.AddWithValue("@Password", aUser.Password);
                        AddUser.Parameters.AddWithValue("@Firstname", aUser.Fname);
                        AddUser.Parameters.AddWithValue("@Lastname", aUser.Lname);
                        AddUser.Parameters.AddWithValue("@AccessGroup", aUser.AccessGroup);
                        AddUser.Parameters.AddWithValue("@GroupName", aUser.GroupName);

                        int success = AddUser.ExecuteNonQuery();

                        result = Convert.ToBoolean(success);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return result;
        }

        public bool UpdateUser(User aUser)
        {
            bool result;

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand AddUser = new SqlCommand("usp_Update_User", conn))
                {
                    try
                    {
                        conn.Open();
                        AddUser.CommandType = CommandType.StoredProcedure;
                        AddUser.Parameters.AddWithValue("@UserID", aUser.User_ID);
                        AddUser.Parameters.AddWithValue("@Username", aUser.Username);
                        AddUser.Parameters.AddWithValue("@Password", aUser.Password);
                        AddUser.Parameters.AddWithValue("@AccessGroup", aUser.AccessGroup);
                        AddUser.Parameters.AddWithValue("@Firstname", aUser.Fname);
                        AddUser.Parameters.AddWithValue("@Lastname", aUser.Lname);

                        int success = AddUser.ExecuteNonQuery();

                        result = Convert.ToBoolean(success);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            return result;
        }

        public DataTable getUsers()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Select_AllUser", conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter getData = new SqlDataAdapter(cmd))
                        {
                            getData.Fill(dt);
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }

            return dt;
        }

        public DataTable getGroups()
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Select_ALLGroups", conn))
                {
                    try
                    {
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        using (SqlDataAdapter getData = new SqlDataAdapter(cmd))
                        {
                            getData.Fill(dt);
                        }
                    }
                    finally
                    {
                        conn.Close();
                    }

                }
            }

            return dt;
        }

    }
}
