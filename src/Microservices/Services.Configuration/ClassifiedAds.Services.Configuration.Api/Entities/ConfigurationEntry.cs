﻿using System;
using ClassifiedAds.Domain.Entities;

namespace ClassifiedAds.Services.Configuration.Entities
{
    public class ConfigurationEntry : Entity<Guid>, IAggregateRoot
    {
        public string Key { get; set; }

        public string Value { get; set; }

        public string Description { get; set; }

        public bool IsSensitive { get; set; }
    }
}
