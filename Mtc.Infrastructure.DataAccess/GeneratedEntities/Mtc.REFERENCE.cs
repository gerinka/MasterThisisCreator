﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 5/21/2016 5:49:28 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace MtcModel
{

    /// <summary>
    /// There are no comments for MtcModel.REFERENCE in the schema.
    /// </summary>
    public partial class REFERENCE    {

        public REFERENCE()
        {
            OnCreated();
        }


        #region Properties
    
        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual int Id
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for ReferenceTypeId in the schema.
        /// </summary>
        public virtual System.Nullable<ReferenceType> ReferenceTypeId
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        public virtual string Name
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        public virtual global::System.Nullable<int> Order
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for DocumentId in the schema.
        /// </summary>
        public virtual int DocumentId
        {
            get;
            set;
        }


        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for DOCUMENT in the schema.
        /// </summary>
        public virtual DOCUMENT DOCUMENT
        {
            get;
            set;
        }

        #endregion
    
        #region Extensibility Method Definitions
        partial void OnCreated();
        #endregion
    }

}
