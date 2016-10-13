﻿using System;

namespace BitBucket.REST.API.Models
{
    public class Connection
    {
        public Connection(Uri apiUrl, Credentials credentials)
        {
            ApiUrl = apiUrl;
            Credentials = credentials;
        }

        public string GetBitbucketUrl()
        {
            return "https://bitbucket.org";
        }

        public string GetHost() { return new Uri(GetBitbucketUrl()).Host; }

        public Credentials Credentials { get; private set; }

        public Uri ApiUrl { get; private set; }
    }
}