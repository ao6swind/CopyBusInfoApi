using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using Repositories.Interfaces;
using Pluralize.NET.Core;
using Dapper;
using MySql.Data.MySqlClient;
using DbContexts;

namespace Repositories.Dapper
{
    public class GeneralQuery<T> : IGeneralQuery<T> where T : class
    {
        public bool Create(T entity)
        {
            DynamicParameters parameters = new DynamicParameters();
            StringBuilder columnBuilder = new StringBuilder();
            StringBuilder valuesBuilder = new StringBuilder();

            foreach(PropertyInfo property in typeof(T).GetProperties())
            {
                columnBuilder.Append($"{property.Name},");
                valuesBuilder.Append($"@{property.Name},");
                parameters.Add(property.Name, property.GetValue(entity));
            }

            string table = GetTableName();
            string column = columnBuilder.ToString();
            string values = valuesBuilder.ToString();
            column = column.Substring(0, column.Length - 1);
            values = values.Substring(0, values.Length - 1);
            
            string sql = $"INSERT INTO {table}({column}) VALUES({values})";
            using(MySqlConnection conn = new MySqlConnection(DbConnectionString.DbEasyLife))
            {
                conn.Open();
                conn.Execute(sql, parameters);
            }
            return true;
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public T Find(int id)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("id", id);
            string table = GetTableName();
            string key = String.Empty;

            foreach(PropertyInfo property in typeof(T).GetProperties())
            {
                KeyAttribute attribute = Attribute.GetCustomAttribute(property, typeof(KeyAttribute)) as KeyAttribute;
                if(attribute != null)
                {
                    key = property.Name;
                    break;
                }
            }

            string sql = $"SELECT * FROM {table} WHERE {key} = @id";
            Console.WriteLine(sql);
            using(MySqlConnection conn = new MySqlConnection(DbConnectionString.DbEasyLife))
            {
                conn.Open();
                return conn.Query<T>(sql, parameters).FirstOrDefault<T>();
            }
        }

        public List<T> List()
        {
            throw new System.NotImplementedException();
        }

        public bool Update(int id, T entity)
        {
            string table = GetTableName();
            string update = String.Empty;
            string key = String.Empty;

            StringBuilder updateBuilder = new StringBuilder();
            DynamicParameters parameters = new DynamicParameters();

            foreach(PropertyInfo property in typeof(T).GetProperties())
            {
                KeyAttribute attribute = Attribute.GetCustomAttribute(property, typeof(KeyAttribute)) as KeyAttribute;
                if(attribute != null)
                {
                    key = property.Name;
                }
                else
                {
                    updateBuilder.Append($"{property.Name} = @{property.Name},");
                    parameters.Add(property.Name, property.GetValue(entity));
                }
            }
            parameters.Add("id", id);
            update = updateBuilder.ToString();
            update = update.Substring(0, update.Length - 1);

            string sql = $"UPDATE {table} SET {update} WHERE {key} = @id";
            using(MySqlConnection conn = new MySqlConnection(DbConnectionString.DbEasyLife))
            {
                conn.Open();
                conn.Execute(sql, parameters);
            }
            return true;
        }

        private string GetTableName()
        {
            return new Pluralizer().Pluralize(typeof(T).Name);
        }
    }
}