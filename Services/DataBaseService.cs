using ExpertPlanner.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpertPlanner.Services
{
    public class DatabaseService
    {
        private readonly ApplicationDbContext _context;

        public DatabaseService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DefaultTable>> GetDataFromTableAsync(string tableName)
        {
            var tableColumns = _context.Model.FindEntityType(typeof(DefaultTable)).GetProperties().Select(x => x.Name).ToList();
            var columnList = string.Join(", ", tableColumns.Select(c => $"\"{c}\""));
            var query = new List<DefaultTable>();

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                await _context.Database.OpenConnectionAsync();

                command.CommandText = $"SELECT {columnList} FROM \"{tableName}\"";

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
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

        public async Task UpdateDataInTableAsync(string tableName, List<DefaultTable> updatedData)
        {
            foreach (var item in updatedData)
            {
                var sql = $"UPDATE \"{tableName}\" SET LastName = '{item.LastName}', FirstName = '{item.FirstName}', MiddleName = '{item.MiddleName}',  Link = '{item.Link}', Position = '{item.Position}', Monday = '{item.Monday}', Tuesday = '{item.Tuesday}', Wednesday = '{item.Wednesday}', Thursday = '{item.Thursday}', Friday = '{item.Friday}', Saturday = '{item.Saturday}', Sunday = '{item.Sunday}' WHERE Id = {item.Id}";
                await _context.Database.ExecuteSqlRawAsync(sql);
            }
        }

        public List<string> GetTableNames()
        {
            var tableNames = new List<string>();

            var connection = _context.Database.GetDbConnection();
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = "SELECT name FROM sqlite_master WHERE type='table' AND name LIKE 'Grafik_%'";
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
