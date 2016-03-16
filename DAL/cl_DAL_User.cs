﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class cl_DAL_User
    {
        Utilities.SQLCon _conn;
        DataTable _dt = new DataTable();
        Utilities.HashMD5 MD5 = new Utilities.HashMD5();

        public bool CheckUserLogin( string _user , string _pass )
        {
            bool flag = false;

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable( "SELECT * FROM tb_Users WHERE UserID = N'" + _user + "' and Password = N'" + MD5.toMD5( _pass ) + "'" );

                if ( _dt.Rows.Count == 1 )
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

            }
            catch ( Exception ex )
            {
                flag = false;
            }

            _conn.closeConnection();
            return flag;
        }

        public cl_PRO_User getUserLogin( string _uName )
        {
            cl_PRO_User _uLogin = new cl_PRO_User();

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable( "SELECT * FROM tb_Users WHERE UserID = N'" + _uName + "'" );

                if ( _dt.Rows.Count == 1 )
                {
                    _uLogin.UserName = _dt.Rows[0]["UserID"].ToString();
                    _uLogin.FullName = _dt.Rows[0]["FullName"].ToString();
                    _uLogin.Password = _dt.Rows[0]["Password"].ToString();
                    _uLogin.DepartmentID = _dt.Rows[0]["DepartmentID"].ToString();
                    _uLogin.ForceChangePass = _dt.Rows[0]["ForceChangePass"].ToString();
                }
            }
            catch ( Exception ex )
            {

            }

            _conn.closeConnection();

            return _uLogin;
        }

        public bool updatePassword( string _newPass , string _userID )
        {
            bool check = true;

            try
            {
                _conn = new Utilities.SQLCon();                

                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "[USER].[ChangePass]";
                command.Parameters.AddWithValue( "@NewPass" , MD5.toMD5( _newPass ) );
                command.Parameters.AddWithValue( "@UserID" , _userID );

                SqlParameter _output = command.Parameters.Add("@output", SqlDbType.NVarChar, 50);
                _output.Direction = ParameterDirection.Output;

                command.Connection = _conn.getConnection();

                int effect = command.ExecuteNonQuery();
                if ( effect > 0 )
                {
                    check = true;
                }
                else
                {
                    check = false;
                }
            }
            catch ( Exception ex )
            {
                check = false;
                throw new Exception( ex.Message );
            }
            return check;
        }

        public bool checkUserRole( string _user , string _role )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable( "SELECT * FROM tb_User_UserRoles WHERE UserID = N'" + _user + "' and RoleID = N'" + _role + "'" );

                if ( _dt.Rows.Count == 1 )
                {
                    check = true;
                }
                else
                {
                    check = false;
                }

            }
            catch ( Exception ex )
            {
                check = false;
            }

            _conn.closeConnection();
            return check;
        }

        public bool checkUserRoleOverride(string _user, string _role)
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable("SELECT * FROM tb_User_UserRoleOverride WHERE UserID = N'" + _user + "' and RoleID = N'" + _role + "'");

                if (_dt.Rows.Count == 1)
                {
                    check = true;
                }
                else
                {
                    check = false;
                }

            }
            catch (Exception ex)
            {
                check = false;
            }

            _conn.closeConnection();
            return check;
        }

        public bool checkUserRegion( string _user , string _region )
        {
            bool check = false;

            try
            {
                _conn = new Utilities.SQLCon();
                _conn.getConnection();
                _dt = _conn.returnDataTable( "select * from tb_User_Region where UserID = '" + _user + "' and Region = '" + _region + "'" );

                if ( _dt.Rows.Count == 1 )
                {
                    check = true;
                }
                else
                {
                    check = false;
                }

            }
            catch ( Exception ex )
            {
                check = false;
            }

            _conn.closeConnection();
            return check;
        }
    }
}