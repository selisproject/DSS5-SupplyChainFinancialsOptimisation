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
    /// The SupplierExtraInformation class
    ///
    /// </summary>
    [Serializable]
    [DataContract]
    public class SupplierExtraInformation : IDomainModelClass
    {
        #region SupplierExtraInformation's Fields

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
        [DataMember(Name="OccurenceBadDebts")]
        protected string occurenceBadDebts;
        [DataMember(Name="ExistenceCounterClaims")]
        protected string existenceCounterClaims;
        [DataMember(Name="HasCompanyAssigned")]
        protected string hasCompanyAssigned;
        [DataMember(Name="AreCompanyReceivables")]
        protected string areCompanyReceivables;
        [DataMember(Name="VersionTimestamp")]
        protected byte[] versionTimestamp;

        #endregion
        #region SupplierExtraInformation's Properties
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
/// The OccurenceBadDebts property
///
/// </summary>
///
        public virtual string OccurenceBadDebts
        {
            get
            {
                return occurenceBadDebts;
            }
            set
            {
                occurenceBadDebts = value;
            }
        }
/// <summary>
/// The ExistenceCounterClaims property
///
/// </summary>
///
        public virtual string ExistenceCounterClaims
        {
            get
            {
                return existenceCounterClaims;
            }
            set
            {
                existenceCounterClaims = value;
            }
        }
/// <summary>
/// The HasCompanyAssigned property
///
/// </summary>
///
        public virtual string HasCompanyAssigned
        {
            get
            {
                return hasCompanyAssigned;
            }
            set
            {
                hasCompanyAssigned = value;
            }
        }
/// <summary>
/// The AreCompanyReceivables property
///
/// </summary>
///
        public virtual string AreCompanyReceivables
        {
            get
            {
                return areCompanyReceivables;
            }
            set
            {
                areCompanyReceivables = value;
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
/// Public constructors of the SupplierExtraInformation class
/// </summary>
/// <returns>New SupplierExtraInformation object</returns>
/// <remarks></remarks>
        public SupplierExtraInformation() {}
        #endregion
        #region Methods

        public virtual List<string> _Validate(bool throwException = true)
        {
            var __errors = new List<string>();
            if (Id == null)
            {
                __errors.Add("Property 'Id' is required.");
            }
            if (OccurenceBadDebts != null && OccurenceBadDebts.Length > 100)
            {
                __errors.Add("Length of property 'OccurenceBadDebts' cannot be greater than 100.");
            }
            if (ExistenceCounterClaims != null && ExistenceCounterClaims.Length > 100)
            {
                __errors.Add("Length of property 'ExistenceCounterClaims' cannot be greater than 100.");
            }
            if (HasCompanyAssigned != null && HasCompanyAssigned.Length > 100)
            {
                __errors.Add("Length of property 'HasCompanyAssigned' cannot be greater than 100.");
            }
            if (AreCompanyReceivables != null && AreCompanyReceivables.Length > 100)
            {
                __errors.Add("Length of property 'AreCompanyReceivables' cannot be greater than 100.");
            }
            if (throwException && __errors.Any())
            {
                throw new zAppDev.DotNet.Framework.Exceptions.BusinessException("An instance of TypeClass 'SupplierExtraInformation' has validation errors:\r\n\r\n" + string.Join("\r\n", __errors));
            }
            return __errors;
        }

        public virtual int _GetUniqueIdentifier()
        {
            var hashCode = 399326290;
            hashCode = hashCode * -1521134295 + (Id?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (OccurenceBadDebts?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (ExistenceCounterClaims?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (HasCompanyAssigned?.GetHashCode() ?? 0);
            hashCode = hashCode * -1521134295 + (AreCompanyReceivables?.GetHashCode() ?? 0);
            return hashCode;
        }






/// <summary>
/// Copies the current object to a new instance
/// </summary>
/// <param name="deep">Copy members that refer to objects external to this class (not dependent)</param>
/// <param name="copiedObjects">Objects that should be reused</param>
/// <param name="asNew">Copy the current object as a new one, ready to be persisted, along all its members.</param>
/// <param name="reuseNestedObjects">If asNew is true, this flag if set, forces the reuse of all external objects.</param>
/// <param name="copy">Optional - An existing [SupplierExtraInformation] instance to use as the destination.</param>
/// <returns>A copy of the object</returns>
        public virtual SupplierExtraInformation Copy(bool deep=false, Hashtable copiedObjects=null, bool asNew=false, bool reuseNestedObjects = false, SupplierExtraInformation copy = null)
        {
            if(copiedObjects == null)
            {
                copiedObjects = new Hashtable();
            }
            if (copy == null && copiedObjects.Contains(this))
                return (SupplierExtraInformation)copiedObjects[this];
            copy = copy ?? new SupplierExtraInformation();
            if (!asNew)
            {
                copy.TransientId = this.TransientId;
                copy.Id = this.Id;
            }
            copy.OccurenceBadDebts = this.OccurenceBadDebts;
            copy.ExistenceCounterClaims = this.ExistenceCounterClaims;
            copy.HasCompanyAssigned = this.HasCompanyAssigned;
            copy.AreCompanyReceivables = this.AreCompanyReceivables;
            if (!copiedObjects.Contains(this))
            {
                copiedObjects.Add(this, copy);
            }
            return copy;
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as SupplierExtraInformation;
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
        public static bool operator ==(SupplierExtraInformation x, SupplierExtraInformation y)
        {
            // By default, == and Equals compares references. In order to
            // maintain these semantics with entities, we need to compare by
            // identity value. The Equals(x, y) override is used to guard
            // against null values; it then calls EntityEquals().
            return Equals(x, y);
        }

// Maintain inequality operator semantics for entities.
        public static bool operator !=(SupplierExtraInformation x, SupplierExtraInformation y)
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
        protected bool HasSameNonDefaultIdAs(SupplierExtraInformation compareTo)
        {
            return !this.IsTransient() && !compareTo.IsTransient() && this.Id.Equals(compareTo.Id);
        }

        #endregion


    }
}
