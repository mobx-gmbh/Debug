using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Serialization;

namespace MobX
{
    [Serializable]
    internal class DebugSettingsData
    {
        [Serializable]
        private struct Entry
        {
            public LogType logType;
            public string[] logCategories;
        }

        [SerializeField] private Entry[] blocked;
        [SerializeField] private Entry[] unblocked;

        public Dictionary<LogType, HashSet<LogCategory>> BlockedLogCategories
        {
            get
            {
                Dictionary<LogType, HashSet<LogCategory>> blockedLogCategories = new()
                {
                    {LogType.Log, new HashSet<LogCategory>()},
                    {LogType.Warning, new HashSet<LogCategory>()},
                    {LogType.Error, new HashSet<LogCategory>()},
                    {LogType.Exception, new HashSet<LogCategory>()},
                    {LogType.Assert, new HashSet<LogCategory>()}
                };

                foreach (var entry in blocked)
                {
                    foreach (var categoryName in entry.logCategories)
                    {
                        blockedLogCategories[entry.logType].Add(LogCategory.From(categoryName));
                    }
                }

                return blockedLogCategories;
            }
            set
            {
                var buffer = new List<Entry>();
                foreach (var (logType, logCategories) in value)
                {
                    var entry = new Entry
                    {
                        logType = logType,
                        logCategories = logCategories.Select(element => element.Name).ToArray()
                    };
                    buffer.Add(entry);
                }

                blocked = buffer.ToArray();
            }
        }

        public Dictionary<LogType, HashSet<LogCategory>> UnblockedLogCategories
        {
            get
            {
                Dictionary<LogType, HashSet<LogCategory>> unblockedLogCategories = new()
                {
                    {LogType.Log, new HashSet<LogCategory>()},
                    {LogType.Warning, new HashSet<LogCategory>()},
                    {LogType.Error, new HashSet<LogCategory>()},
                    {LogType.Exception, new HashSet<LogCategory>()},
                    {LogType.Assert, new HashSet<LogCategory>()}
                };

                foreach (var entry in unblocked)
                {
                    foreach (var categoryName in entry.logCategories)
                    {
                        unblockedLogCategories[entry.logType].Add(LogCategory.From(categoryName));
                    }
                }

                return unblockedLogCategories;
            }
            set
            {
                var buffer = new List<Entry>();
                foreach (var (logType, logCategories) in value)
                {
                    var entry = new Entry
                    {
                        logType = logType,
                        logCategories = logCategories.Select(element => element.Name).ToArray()
                    };
                    buffer.Add(entry);
                }

                unblocked = buffer.ToArray();
            }
        }
    }
}