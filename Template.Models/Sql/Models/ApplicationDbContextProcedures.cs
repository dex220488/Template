﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.Data.SqlClient;
using System;
using System.Threading.Tasks;
using Template.Models.Sql.Models;

namespace Template.Models.Sql.Models
{
    public partial class ApplicationDbContextProcedures
    {
        private readonly ApplicationDbContext _context;

        public ApplicationDbContextProcedures(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TemplateTableSelectProcedureResult[]> TemplateTableSelectProcedure(string Description)
        {
            var parameterDescription = new SqlParameter
            {
                ParameterName = "Description",
                Precision = 50,
                Size = 50,
                SqlDbType = System.Data.SqlDbType.VarChar,
                Value = Description,
            };

            var result = await _context.SqlQuery<TemplateTableSelectProcedureResult>("EXEC [dbo].[TemplateTableSelectProcedure] @Description  ",parameterDescription);

            return result;
        }
    }
}
