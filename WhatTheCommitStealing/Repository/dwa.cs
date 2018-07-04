using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WhatTheCommitStealing.Repository
{
    public class Dwa
    {
        public string GetStuff()
        {
            Random random = new Random();
            string[] commits = File.ReadAllLines(@"funny.txt");
            return commits[random.Next(commits.Length)];
        }

    }
}
