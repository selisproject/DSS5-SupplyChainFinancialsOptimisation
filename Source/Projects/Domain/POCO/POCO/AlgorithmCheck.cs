// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Workflow;
using zAppDev.DotNet.Framework.Identity.Model;

namespace DSS5_SupplyChainFinancialsOptimisation.BO
{
    /// <summary>
    /// The AlgorithmCheck class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class AlgorithmCheck : IDomainModelClass
    {
        #region AlgorithmCheck's Fields

        protected Guid _transientId= Guid.NewGuid();
        public virtual Guid TransientId
        {
            get
            {
                return _transientId;
            }
            set
            {
                _transientId = value;
            }
        }
        [DataMember(Name="Id")]
        protected int? id = 0;
        [DataMember(Name="AnnualTurnover")]
        protected decimal? annualTurnover;
        [DataMember(Name="B2B")]
        protected string b2B;
        [DataMember(Name="B2C")]
        protected string b2C;
        [DataMember(Name="PaymentTerm")]
        protected decimal? paymentTerm;
        [DataMember(Name="AveragePaymentTerm")]
        protected decimal? averagePaymentTerm;
        [DataMember(Name="AverageInvoiceValue")]
        protected decimal? averageInvoiceValue;
        [DataMember(Name="EquityRatio")]
        protected decimal? equityRatio;
        [DataMember(Name="AlgorithmCount")]
        protected int? algorithmCount;
        [DataMember(Name="Result")]
        protected string result;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region AlgorithmCheck's Properties
/// <summary>
/// The Id property
///
/// </summary>
///
        [Key]
        public virtual int? Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
/// <summary>
/// The AnnualTurnover property
///
/// </summary>
///
        public virtual decimal? AnnualTurnover
        {
            get
            {
                return annualTurnover;
            }
            set
            {
                annualTurnover = value;
            }
        }
/// <summary>
/// The B2B property
///
/// </summary>
///
        public virtual string B2B
        {
            get
            {
                return b2B;
            }
            set
            {
                b2B = value;
            }
        }
/// <summary>
/// The B2C property
///
/// </summary>
///
        public virtual string B2C
        {
            get
            {
                return b2C;
            }
            set
            {
                b2C = value;
            }
        }
/// <summary>
/// The PaymentTerm property
///
/// </summary>
///
        public virtual decimal? PaymentTerm
        {
            get
            {
                return paymentTerm;
            }
            set
            {
                paymentTerm = value;
            }
        }
/// <summary>
/// The AveragePaymentTerm property
///
/// </summary>
///
        public virtual decimal? AveragePaymentTerm
        {
            get
            {
                return averagePaymentTerm;
            }
            set
            {
                averagePaymentTerm = value;
            }
        }
/// <summary>
/// The AverageInvoiceValue property
///
/// </summary>
///
        public virtual decimal? AverageInvoiceValue
        {
            get
            {
                return averageInvoiceValue;
            }
            set
            {
                averageInvoiceValue = value;
            }
        }
/// <summary>
/// The EquityRatio property
///
/// </summary>
///
        public virtual decimal? EquityRatio
        {
            get
            {
                return equityRatio;
            }
            set
            {
                equityRatio = value;
            }
        }
/// <summary>
/// The AlgorithmCount property
///
/// </summary>
///
        public virtual int? AlgorithmCount
        {
            get
            {
                return algorithmCount;
            }
            set
            {
                algorithmCount = value;
            }
        }
/// <summary>
/// The Result property
///
/// </summary>
///
        public virtual string Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }
/// <summary>
/// The VersionTimestamp property
///Provides concurrency control for the class
/// </summary>
///
        public virtual byte[] VersionTimestamp
        {
            get
            {
                return versionTimestamp;
            }
            set
            {
                versionTimestamp = value;
            }
        }
        #endregion
        #region Constructors
/// <summary>
/// Public constructors of the AlgorithmCheck class
/// </summary>
/// <returns>New AlgorithmCheck object</returns>
/// <remarks></remarks>
        public AlgorithmCheck() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (B2B != null && B2B.Length > 100)
            {
                __errors.Add("Length of property 'B2B' cannot be greater than 100.");
            }
            if (B2C != null && B2C.Length > 100)
            {
                __errors.Add("Length of property 'B2C' cannot be greater than 100.");
            }
            if (Result != null && Result.Length > 100)
            {
                __errors.Add("Length of property 'Result' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'AlgorithmCheck' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (AnnualTurnover?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (B2B?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (B2C?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (PaymentTerm?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (AveragePaymentTerm?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (AverageInvoiceValue?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (EquityRatio?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (AlgorithmCount?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (Result?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [AlgorithmCheck] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual AlgorithmCheck Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, AlgorithmCheck copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (AlgorithmCheck)copiedObjects[this];
            copy = copy ?? new AlgorithmCheck();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.AnnualTurnover = this.AnnualTurnover;
            copy.B2B = this.B2B;
            copy.B2C = this.B2C;
            copy.PaymentTerm = this.PaymentTerm;
            copy.AveragePaymentTerm = this.AveragePaymentTerm;
            copy.AverageInvoiceValue = this.AverageInvoiceValue;
            copy.EquityRatio = this.EquityRatio;
            copy.AlgorithmCount = this.AlgorithmCount;
            copy.Result = this.Result;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as AlgorithmCheck;
            if (ReferenceEquals(this, compareTo))
            {
                return true;
            }
            if (compareTo == null || !this.GetType().Equals(compareTo.GetTypeUnproxied()))
            {
                return false;
            }
            if (this.HasSameNonDefaultIdAs(compareTo))
            {
                return true;
            }
            // Since the Ids aren't the same, both of them must be transient to
            // compare domain signatures; because if one is transient and the
            // other is a persisted entity, then they cannot be the same object.
            return this.IsTransient() && compareTo.IsTransient() && (base.Equals(compareTo) || this.TransientId.Equals(compareTo.TransientId));
        }

// Maintain equality operator semantics for entities.
        public static bool operator ==(AlgorithmCheck x, AlgorithmCheck y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(AlgorithmCheck x, AlgorithmCheck y)
        {
            return !(x == y);
        }

        private PropertyInfo __propertyKeyCache;
        public virtual PropertyInfo GetPrimaryKey()
        {
            if (__propertyKeyCache == null)
            {
                __propertyKeyCache = this.GetType().GetProperty("Id");
            }
            return __propertyKeyCache;
        }


/// <summary>
///     To help ensure hashcode uniqueness, a carefully selected random number multiplier
///     is used within the calculation.  Goodrich and Tamassia's Data Structures and
///     Algorithms in Java asserts that 31, 33, 37, 39 and 41 will produce the fewest number
///     of collissions.  See http://computinglife.wordpress.com/2008/11/20/why-do-hash-functions-use-prime-numbers/
///     for more information.
/// </summary>
        private const int HashMultiplier = 31;
        private int? cachedHashcode;

        public override int GetHashCode()
        {
            if (this.cachedHashcode.HasValue)
            {
                return this.cachedHashcode.Value;
            }
            if (this.IsTransient())
            {
                //this.cachedHashcode = base.GetHashCode();
                return this.TransientId.GetHashCode(); //don't cache because this won't stay transient forever
            }
            else
            {
                unchecked
                {
                    // It's possible for two objects to return the same hash code based on
                    // identically valued properties, even if they're of two different types,
                    // so we include the object's type in the hash calculation
                    var hashCode = this.GetType().GetHashCode();
                    this.cachedHashcode = (hashCode * HashMultiplier) ^ this.Id.GetHashCode();
                }
            }
            return this.cachedHashcode.Value;
        }

/// <summary>
///     Transient objects are not associated with an item already in storage.  For instance,
///     a Customer is transient if its Id is 0.  It's virtual to allow NHibernate-backed
///     objects to be lazily loaded.
/// </summary>
        public virtual bool IsTransient()
        {
            return this.Id == default(int) || this.Id.Equals(default(int));
        }

/// <summary>
///     When NHibernate proxies objects, it masks the type of the actual entity object.
///     This wrapper burrows into the proxied object to get its actual type.
///
///     Although this assumes NHibernate is being used, it doesn't require any NHibernate
///     related dependencies and has no bad side effects if NHibernate isn't being used.
///
///     Related discussion is at http://groups.google.com/group/sharp-architecture/browse_thread/thread/ddd05f9baede023a ...thanks Jay Oliver!
/// </summary>
        protected virtual System.Type GetTypeUnproxied()
        {
            return this.GetType();
        }

/// <summary>
///     Returns true if self and the provided entity have the same Id values
///     and the Ids are not of the default Id value
/// </summary>
        protected bool HasSameNonDefaultIdAs(AlgorithmCheck compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}
