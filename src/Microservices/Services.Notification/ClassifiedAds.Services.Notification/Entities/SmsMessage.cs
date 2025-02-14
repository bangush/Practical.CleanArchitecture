﻿using ClassifiedAds.Domain.Entities;
using System;

namespace ClassifiedAds.Services.Notification.Entities
{
    public class SmsMessage : Entity<Guid>, IAggregateRoot
    {
        public string Message { get; set; }

        public string PhoneNumber { get; set; }

        public int AttemptCount { get; set; }

        public int MaxAttemptCount { get; set; }

        public DateTimeOffset? NextAttemptDateTime { get; set; }

        public DateTimeOffset? ExpiredDateTime { get; set; }

        public string Log { get; set; }

        public DateTimeOffset? SentDateTime { get; set; }

        public Guid? CopyFromId { get; set; }
    }
}
