﻿using DataAccess.Contracts;
using System.Text.Json.Serialization;

namespace Minions.Data
{
    public class Campaign : IModel
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();


        public string? Name { get; set; }
        public string? Description { get; set; }

        public string? GM { get; set; }

        public int PlayerCount { get; set; }

        public List<string>? PlayerNames { get; set; } = new List<string>();

        [JsonIgnore]
        public string PlayerDisplay => (PlayerNames == null || PlayerNames.Count == 0) ? "" : string.Join(", ", PlayerNames);

        [JsonIgnore]

        public double RunTime => double.Ceiling((System.DateTime.Now - (this.DateTime ?? System.DateTime.Now)).TotalDays);
        public DateTime? DateTime { get; set; }









    }
}
