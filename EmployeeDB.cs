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
            "( id           INTEGER PRIMARY KEY AUTOINCREMENT," +
            " name          VARCHAR NOT NULL," +
            " lastname      VARCHAR NOT NULL," +
            " mail          VARCHAR UNIQUE NOT NULL," +
            " dateOfBirth   DATE DEFAULT(1012000) NOT NULL," +
            " password      VARCHAR NOT NULL);";
        private const string CREATE_TABLE_UNIVERSITY = "CREATE TABLE universities " +
            "(id INTEGER PRIMARY KEY AUTOINCREMENT," +
            "name STRING  UNIQUE NOT NULL);";
        private const string CREATE_TABLE_APPLICATIONS = "CREATE TABLE applications (" +
            "[id]          INTEGER PRIMARY KEY AUTOINCREMENT," +
            "user_id       INTEGER REFERENCES users(id) NOT NULL," +
            "university_id INTEGER REFERENCES universities(id) NOT NULL," +
            "status        STRING NOT NULL" +
            "type          STRING  NOT NULL);";
        private const string CREATE_TABLE_REQUESTS = "CREATE TABLE requests (" +
            "id             INTEGER PRIMARY KEY AUTOINCREMENT," +
            "user_id        INTEGER NOT NULL," +
            "university_id  INTEGER NOT NULL," +
            "snils          VARCHAR NOT NULL," +
            "inn            VARCHAR NOT NULL," +
            "photo          VARCHAR NOT NULL," +
            "pass_scan      VARCHAR NOT NULL);";
        private static void CreateDBTables()
        {
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_WRC))
            {
                connection.Open();
                var command = new SQLiteCommand(CREATE_TABLE_USERS, connection);
                command.ExecuteNonQuery();
                command.CommandText = CREATE_TABLE_UNIVERSITY;
                command.ExecuteNonQuery();
                command.CommandText = CREATE_TABLE_APPLICATIONS;
                command.ExecuteNonQuery();
                command.CommandText = CREATE_TABLE_REQUESTS;
                command.ExecuteNonQuery();
            }
        }
        public static object[] ReadUserInfoMail(string mail)
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
                    if (reader.HasRows && reader.Read())
                    {
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
        public static object[] ReadUserInfoId(int id)
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT * FROM users WHERE id={id}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        return new object[] { reader.GetValue(1),
                            reader.GetValue(2),
                            reader.GetValue(3),
                            reader.GetDateTime(4)};
                    }
                }
            }
            return null;
        }
        public static List<object[]> ReadUniversities()
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            var universities = new List<object[]>();
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT * FROM universities";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            universities.Add(new object[] { reader.GetValue(0),
                            reader.GetValue(1)}); 
                        }
                    }
                }
            }
            universities.Reverse();
            return universities;
        }
        /// <summary>
        /// Читает из бд заявления
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static List<object[]> ReadUserApplications(int id)
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            var applications = new List<object[]>();
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT * FROM applications WHERE user_id={id}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            applications.Add(new object[] { reader.GetValue(2),// univerId
                                                reader.GetValue(3),//status
                                                reader.GetValue(4)});//type
                        }
                    }
                }
            }
            return applications;
        }
        /// <summary>
        /// Создает запрос к базе по допИнформации и если ничего нету то null
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static object[] ReadUserRequest(int id)
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT * FROM requests WHERE user_id={id}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        return new object[] { reader.GetValue(2),
                                                reader.GetValue(3),// snils
                                                reader.GetValue(4),//inn
                                                reader.GetValue(5),// photo
                                                reader.GetValue(6)};// pass
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
        public static void AddApplications(int idUser, int idUniversity, string type)
        {
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_WRC))
            {
                connection.Open();
                int reqId = GetReqId(idUser, idUniversity);
                if (reqId==-1)
                {
                    return;
                }
                string expression = $"INSERT INTO applications" +
                    $"(user_id, university_id, status, type, request_id) " +
                    $"VALUES({idUser}, {idUniversity} ,\"not checked\", \"{type}\", {reqId})";
                var command = new SQLiteCommand(expression, connection);
                command.ExecuteNonQuery();
            }
        }
        public static void AddRequests(string pathPhoto, string pathPass, int idUser, int idUniversity, string snils, string inn)
        {
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_WRC))
            {
                connection.Open();
                SQLiteParameter snilsParam = new SQLiteParameter("@snils", snils);
                SQLiteParameter innParam = new SQLiteParameter("@inn", inn);
                string expression = $"INSERT INTO requests " +
                    $"(user_id, university_id, snils, inn, photo, pass_scan)" +
                    $" VALUES ({idUser}, {idUniversity}, @snils, @inn, \"{pathPhoto}\", \"{pathPass}\" )";
                var command = new SQLiteCommand(expression, connection);
                command.Parameters.Add(snilsParam);
                command.Parameters.Add(innParam);
                command.ExecuteNonQuery();
            }
        }

        public static bool CheckUserRequest(int id, int univerId)
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT * FROM requests WHERE user_id={id} AND university_id={univerId}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    return reader.HasRows;
                }
            }
        }
        public static string GetUniversityName(int univId)
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT name FROM universities WHERE id={univId}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }
            return null;
        }
        public static int GetReqId(int userID, int univerID)
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT id FROM requests WHERE user_id={userID} AND university_id={univerID}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        return reader.GetInt32(0);
                    }
                }
            }
            return -1;
        }

        public static void AddGroup(int userID, string group)
        {
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_WRC))
            {
                connection.Open();
                string expression = $"INSERT INTO userGroup (user_id, stud_group) VALUES({userID}, \"{group}\")";
                var command = new SQLiteCommand(expression, connection);
                command.ExecuteNonQuery();
            }
        }

        public static string GetGroup(int userID)
        {
            if (!File.Exists("StudTransfer.db"))
            {
                CreateDBTables();
            }
            using (var connection = new SQLiteConnection(PATHBD_CONNECT_RO))
            {
                connection.Open();
                string findExpression = $"SELECT stud_group FROM userGroup WHERE user_id={userID}";
                var command = new SQLiteCommand(findExpression, connection);
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows && reader.Read())
                    {
                        return reader.GetString(0);
                    }
                }
            }
            return null;
        }


    }
}
