﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace P_OO_Thesaurus_Thomas_Alexandre
{
    public class ModelIndexingHistory
    {
        private Controler _controler;

        public Controler Controler
        {
            get { return _controler; }
            set { _controler = value; }
        }
        private List<File> _files;

        public List<File> Files
        {
            get { return _files; }
            set { _files = value; }
        }

        private List<Index> _indexList;

        public List<Index> IndexList
        {
            get { return _indexList; }
            set { _indexList = value; }
        }


        private MySqlConnection _connection;

        public ModelIndexingHistory()
        {
            Files = new List<File>();
            IndexList = new List<Index>();

            string server = "localhost";
            string database = "db_p_oo";
            string uid = "root";
            string password = "root";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            _connection = new MySqlConnection(connectionString);
            _connection.Open();

            MySqlCommand com = _connection.CreateCommand();

            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = "SELECT * FROM t_index";
            MySqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Index index = new Index(reader.GetString(1), reader.GetString(2));
                    index.IdIndex = Convert.ToInt32(reader.GetString(0));
                    IndexList.Add(index);
                }
                reader.Close();
            }
            _connection.Close();
        }

        public void UpdateIndexingHistory(Index index, List<string> files)
        {
            IndexList.Clear();
            _connection.Open();

            MySqlCommand com = _connection.CreateCommand();

            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = $"INSERT INTO `t_index` (`idIndex`, `indDateIndexation`, `indPath`) VALUES(DEFAULT, @date, @path);";
            var cmd = new MySqlCommand(com.CommandText, _connection);

            cmd.Parameters.AddWithValue("@date", index.DateIndex);
            cmd.Parameters.AddWithValue("@path", index.PathIndex);
            cmd.Prepare();

            cmd.ExecuteNonQuery();

            string command = string.Empty;
            string[,] allFilesInfos = new string[files.Count, 3];
            for (int i = 0; i < files.Count; i++)
            {
                string[] currentFileInfo = files[i].Split(";");
                for (int j = 0; j < 3; j++)
                {
                    allFilesInfos[i, j] = currentFileInfo[j];
                }
            }
            MySqlCommand insertFileCom = _connection.CreateCommand();
            for (int i = 0; i < files.Count; i++)
            {
                insertFileCom.CommandText += $"INSERT INTO `t_file` (`idFile`, `filName`, `filType`, `filPath`, `fkIndex`) VALUES (DEFAULT, @name" + i + ", @type" + i + ", @path" + i + ", 1);";
            }
                var commandFile = new MySqlCommand(insertFileCom.CommandText, _connection);
            for (int i = 0; i < files.Count; i++)
            {
                commandFile.Parameters.AddWithValue("@name" + i, allFilesInfos[i, 0]);
                commandFile.Parameters.AddWithValue("@type" + i, allFilesInfos[i, 1]);
                commandFile.Parameters.AddWithValue("@path" + i, allFilesInfos[i, 2]);
            }

            commandFile.Prepare();
            commandFile.ExecuteNonQuery();
            _connection.Close();
        }

        public List<Index> GetAndShowHistory()
        {
            IndexList.Clear();
            _connection.Open();

            MySqlCommand com = _connection.CreateCommand();

            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = "SELECT * FROM t_index";
            MySqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Index index = new Index(reader.GetString(1), reader.GetString(2));
                    index.IdIndex = Convert.ToInt32(reader.GetString(0));
                    IndexList.Add(index);
                }
                reader.Close();
            }
            _connection.Close();
            return IndexList;
        }
    }
}
