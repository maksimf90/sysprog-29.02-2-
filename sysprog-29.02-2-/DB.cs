using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sysprog_29._02_2_
{
    public class DB
    {
        
        NpgsqlConnection connection;

        public DB(string connectionString)
        {
            connection = new NpgsqlConnection(connectionString);
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }

        public List<Contact> getContacts()
        {
            List<Contact> result = new List<Contact>();

            connection.Open();
            string commandString = "SELECT * FROM users";
            var command = new NpgsqlCommand(commandString, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new Contact(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }

            connection.Close();

            return result;

        }

        public List<Contact> findContacts(string name)
        {
            List<Contact> result = new List<Contact>();

            connection.Open();
            string commandString = $"SELECT * FROM users WHERE name LIKE '%{name}%'";
            var command = new NpgsqlCommand(commandString, connection);
            NpgsqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                result.Add(new Contact(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }

            connection.Close();

            return result;
        }

        public void addContact(string name, string number)
        {
            connection.Open();

            string searchCommandString = $"SELECT COUNT(*) FROM users WHERE number='{number}'";
            var searchCommand = new NpgsqlCommand(searchCommandString, connection);
            var count = (Int64)searchCommand.ExecuteScalar();

            if (count == 0)
            {
                string insertCommandString = $"INSERT INTO users(name, number) VALUES('{name}', '{number}') RETURNING id";
                var insertCommand = new NpgsqlCommand(insertCommandString, connection);
                insertCommand.ExecuteNonQuery();
            }
            else
            {
                MessageBox.Show("Данный номер уже есть");
            }


            connection.Close();
        }

        public void deleteContact(int id)
        {
            connection.Open();

            string deleteCommandString = $"DELETE FROM users WHERE id={id}";
            var deleteCommand = new NpgsqlCommand(deleteCommandString, connection);
            deleteCommand.ExecuteNonQuery();

            connection.Close();
        }

        public void updateContact(int id, string name, string number)
        {
            connection.Open();

            string updateCommandString = $"UPDATE users SET name='{name}', number='{number}' WHERE id={id}";
            var updateCommand = new NpgsqlCommand(updateCommandString, connection);
            updateCommand.ExecuteNonQuery();

            connection.Close();
        }
    }
}

    
