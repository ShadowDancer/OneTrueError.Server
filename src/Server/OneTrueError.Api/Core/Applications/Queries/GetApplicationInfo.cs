﻿using System;
using DotNetCqs;

namespace OneTrueError.Api.Core.Applications.Queries
{
    /// <summary>
    ///     Get information for an application either by using the key or application id
    /// </summary>
    public class GetApplicationInfo : Query<GetApplicationInfoResult>
    {
        private string _appKey;
        private int _applicationId;

        /// <summary>
        ///     Application key from the user interface
        /// </summary>
        /// <exception cref="FormatException">Not a valid application key.</exception>
        public string AppKey
        {
            get { return _appKey; }
            set
            {
                Guid uid;
                if (!Guid.TryParse(value, out uid))
                    throw new FormatException("'" + value + "' is not a valid application key.");

                _appKey = value;
            }
        }

        /// <summary>
        ///     Application id
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Not a valid application id</exception>
        public int ApplicationId
        {
            get { return _applicationId; }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("value", value, "Not a valid id.");
                _applicationId = value;
            }
        }
    }
}