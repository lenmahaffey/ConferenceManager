﻿using System;
using System.Linq.Expressions;

namespace ConferenceManager.Services.DataAccess
{
    public class QueryOptions<T>
    {
        public Expression<Func<T, Object>> OrderBy { get; set; }
        public Expression<Func<T, Object>> Where { get; set; }

        private string[] includes;
        public string Includes
        {
            set => includes = value.Replace(" ", "").Split(',');
        }
        public string[] GetIncludes() => includes ?? new string[0];

        public bool HasWhere => Where != null;
        public bool HasOrderBy => OrderBy != null;
    }
}
