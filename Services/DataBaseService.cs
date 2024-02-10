using ExpertPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpertPlanner.Services
{
    public class DatabaseService
    {
        private readonly ApplicationDbContext _context;

        public DatabaseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<DefaultTable> GetDataFromTable(string tableName)
        {
            var tableColumns = _context.Model.FindEntityType(typeof(DefaultTable)).GetProperties().Select(x => x.Name).ToList();
            var columnList = string.Join(", ", tableColumns.Select(c => $"\"{c}\"")); // Enclose column names in quotes
            var query = new List<DefaultTable>();

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = $"SELECT {columnList} FROM \"{tableName}\"";

                _context.Database.OpenConnection();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var defaultTable = new DefaultTable();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            var columnName = reader.GetName(i);
                            var property = typeof(DefaultTable).GetProperty(columnName);
                            if (property != null && !reader.IsDBNull(i))
                            {
                                var value = Convert.ChangeType(reader.GetValue(i), property.PropertyType);
                                property.SetValue(defaultTable, value);
                            }
                        }
                        query.Add(defaultTable);
                    }
                }
            }

            return query;
        }


        public List<string> GetTableNames()
        {
            var tableNames = new List<string>();

            var connection = _context.Database.GetDbConnection();
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name LIKE 'default%'";
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tableNames.Add(reader.GetString(0));
                }
            }

            return tableNames;
        }
    }
}
