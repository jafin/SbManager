﻿using System;
using System.Collections.Generic;

namespace SbManager.Models.ViewModels
{
    public class Subscription : IHaveMessageCounts, IHaveStatusInformation, IHaveSettings
    {
        public string Status { get; set; }
        public bool IsReadOnly { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime AccessedAt { get; set; }
        public string TopicName { get; set; }
        public string Name { get; set; }
        public long ActiveMessageCount { get; set; }
        public long DeadLetterCount { get; set; }
        public long ScheduledMessageCount { get; set; }
        public long TransferMessageCount { get; set; }
        public long DeadTransferMessageCount { get; set; }
        public long? SizeInBytes { get; set; }

        public List<Rule> Rules { get; set; }
        public int? NumberOfRules { get { return Rules != null ? Rules.Count : 0; } }
        public Time AutoDeleteOnIdle { get; set; }
        public Time DefaultMessageTTL { get; set; }
        public Time DuplicateDetectionWindow { get; set; }
        public Time LockDuration { get; set; }
    }

    public class Rule
    {
        public string Name { get; set; }
        public string FilterType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Text { get; set; }
    }
}
