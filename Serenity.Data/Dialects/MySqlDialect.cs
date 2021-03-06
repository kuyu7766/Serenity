﻿using System;

namespace Serenity.Data
{
    public class MySqlDialect : ISqlDialect
    {
        public static readonly ISqlDialect Instance = new MySqlDialect();

        public virtual bool CanUseOffsetFetch
        {
            get
            {
                return true;
            }
        }

        public virtual bool CanUseRowNumber
        {
            get
            {
                return false;
            }
        }

        public bool CanUseSkipKeyword
        {
            get
            {
                return false;
            }
        }

        public char CloseQuote
        {
            get
            {
                return '`';
            }
        }

        public string ConcatOperator
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string DateFormat
        {
            get
            {
                return "\\'yyyy-MM-dd\\'";
            }
        }

        public string DateTimeFormat
        {
            get
            {
                return "\'yyyy-MM-dd HH:mm:ss.fff\'";
            }
        }

        public bool IsLikeCaseSensitive
        {
            get
            {
                return false;
            }
        }

        public bool MultipleResultsets
        {
            get
            {
                return false;
            }
        }

        public bool NeedsExecuteBlockStatement
        {
            get
            {
                return false;
            }
        }

        public virtual string OffsetFormat
        {
            get
            {
                return " OFFSET {0}";
            }
        }

        public virtual string OffsetFetchFormat
        {
            get
            {
                return " LIMIT {0} OFFSET {1}";
            }
        }

        public char OpenQuote
        {
            get
            {
                return '`';
            }
        }

        public string QuoteIdentifier(string s)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            if (s.StartsWith("`") && s.EndsWith("`"))
                return s;

            return '`' + s + '`';
        }

        public string QuoteUnicodeString(string s)
        {
            if (s.IndexOf('\'') >= 0)
                return "'" + s.Replace("'", "''") + "'";

            return "'" + s + "'";
        }

        public string ScopeIdentityExpression
        {
            get
            {
                return "LAST_INSERT_ID()";
            }
        }

        public string SkipKeyword
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string TakeKeyword
        {
            get
            {
                return "LIMIT";
            }
        }

        public string TimeFormat
        {
            get
            {
                return "\\'HH':'mm':'ss\\'";
            }
        }

        public bool UseReturningIdentity
        {
            get
            {
                return false;
            }
        }

        public bool UseScopeIdentity
        {
            get
            {
                return true;
            }
        }

        public bool UseTakeAtEnd
        {
            get
            {
                return true;
            }
        }
    }
}