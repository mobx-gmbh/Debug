using JetBrains.Annotations;
using System;
using System.Collections.Generic;

namespace MobX
{
    /// <summary>
    /// Custom category for debug logs. Categories can be blocked during runtime.
    /// Predefined LogCategories can be blocked at compile time.
    /// </summary>
    public readonly struct LogCategory : IEqualityComparer<LogCategory>, IComparable<LogCategory>
    {
        #region Categories

        /// <summary> Unassigned value </summary>
        public static readonly LogCategory Log = nameof(Log);

        #endregion


        //--------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Representative name of the category
        /// </summary>
        [PublicAPI] public readonly string Name;

        private readonly int _id;

        /// <summary>
        /// Factory method for a LogCategory.
        /// </summary>
        [PublicAPI]
        public static LogCategory From([NotNull] string name)
        {
            if (name is null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            return new LogCategory(name);
        }

        /// <summary>
        /// Create a new instance.
        /// </summary>
        /// <param name="name">Category name</param>
        public LogCategory(string name)
        {
            name ??= nameof(Log);
            Name = name;
            _id = name.GetHashCode();
        }

        /// <summary>
        /// Returns the pure name of the category.
        /// </summary>
        public override string ToString()
        {
            return Name;
        }

        /// <summary>
        /// Implicit conversion from a string to a LogCategory.
        /// </summary>
        public static implicit operator LogCategory(string name)
        {
            return new LogCategory(name);
        }

        /// <summary>
        /// Implicit conversion from a LogCategory to a string.
        /// </summary>
        public static implicit operator string(LogCategory category)
        {
            return category.Name;
        }

        //--------------------------------------------------------------------------------------------------------------


        #region Equals

        /// <summary>Indicates whether this instance and a specified object are equal.</summary>
        /// <param name="obj">The object to compare with the current instance. </param>
        /// <returns>
        /// <see langword="true" /> if <paramref name="obj" /> and this instance are the same type and represent the same value; otherwise, <see langword="false" />. </returns>
        public override bool Equals(object obj)
        {
            return obj is LogCategory logCategory && Equals(logCategory);
        }

        /// <summary>
        /// Indicates whether this instance and a specified LogCategory are equal.
        /// </summary>
        public bool Equals(LogCategory other)
        {
            return _id == other._id;
        }

        /// <summary>
        /// Indicates whether two instances are equal.
        /// </summary>
        public bool Equals(LogCategory rhs, LogCategory lhs)
        {
            return rhs == lhs;
        }

        /// <summary>Compares the current instance with another object of the same type and returns an integer that indicates whether the current instance precedes, follows, or occurs in the same position in the sort order as the other object. </summary>
        /// <param name="other">An object to compare with this instance. </param>
        /// <returns>A value that indicates the relative order of the objects being compared. The return value has these meanings: Value Meaning Less than zero This instance precedes <paramref name="other" /> in the sort order.  Zero This instance occurs in the same position in the sort order as <paramref name="other" />. Greater than zero This instance follows <paramref name="other" /> in the sort order. </returns>
        public int CompareTo(LogCategory other)
        {
            return _id.CompareTo(other._id);
        }

        /// <summary>
        /// Returns the hash code the passed instance.
        /// </summary>
        public int GetHashCode(LogCategory logCategory)
        {
            return logCategory.GetHashCode();
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }

        /// <summary>
        /// Indicates whether two LogCategories are equal.
        /// </summary>
        /// <param name="rhs"></param>
        /// <param name="lhs"></param>
        /// <returns></returns>
        public static bool operator ==(LogCategory rhs, LogCategory lhs)
        {
            return rhs._id == lhs._id;
        }

        /// <summary>
        /// Indicates whether two LogCategories are not equal.
        /// </summary>
        /// <param name="rhs"></param>
        /// <param name="lhs"></param>
        /// <returns></returns>
        public static bool operator !=(LogCategory rhs, LogCategory lhs)
        {
            return rhs._id != lhs._id;
        }

        #endregion
    }
}