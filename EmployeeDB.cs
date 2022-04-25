using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsTransfer
{
    class EmployeeDB
    {
        private const string PATHBD_CONNECT_WRC = "Data Source=StudTransfer.db";
        private const string PATHBD_CONNECT_RO = "Data Source=StudTransfer.db;Mode=ReadOnly; ";
        private const string CREATE_TABLE_USERS = "CREATE TABLE users " +
            "( id INTEGER PRIMARY KEY AUTOINCREMENT," +
            " name VARCHAR NOT NULL," +
            " lastname VARCHAR NOT NULL," +
            " mail VARCHAR UNIQUE NOT NULL," +
            " dateOfBirth DATE DEFAULT(1012000) NOT NULL," +
            " password VARCHAR NOT NULL);";
        private static void CreateDBTables()
        {
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_WRC))
            {
                connection.Open();
                var command = new SQLiteCommand(CREATE_TABLE_USERS, connection);
                command.ExecuteNonQuery();
            }
        }
        public static object[] ReadUserInfo(string mail)
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT * FROM users WHERE mail={mail}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        return new object[] { reader.GetValue(1),
                            reader.GetValue(2),
                            reader.GetValue(3),
                            reader.GetValue(4),
                            reader.GetValue(5)};
                    }
                }
            }
            return null;
        }
        public static void AddUser(string[] data)
        {
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_WRC))
            {
                connection.Open();
                string expression = $"INSERT INTO users (name, lastname, mail, dateOfBirth, password)" +
                    $" VALUES('{data[0]}', '{data[1]}', '{data[2]}', '{data[3]}', '{data[4]}');";
                var command = new SQLiteCommand(expression, connection);
                command.ExecuteNonQuery();
            }
        }
        public static void AddUniversities(string name)
        {
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_WRC))
            {
                connection.Open();
                string expression = $"INSERT INTO universities (name)" +
                    $" VALUES('{name}']);";
                var command = new SQLiteCommand(expression, connection);
                command.ExecuteNonQuery();
            }
        }
        
        
    }
}
