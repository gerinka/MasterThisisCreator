﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework DbContext template.
// Code is generated on: 7/2/2016 9:33:21 PM
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
    /// There are no comments for MtcModel.STRUCTURECONTENT in the schema.
    /// </summary>
    public partial class STRUCTURECONTENT    {

        public STRUCTURECONTENT()
        {
          this.CurrentProgress = 0;
          this.MinWordCount = 1;
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
        /// There are no comments for StructureElementId in the schema.
        /// </summary>
        public virtual int StructureElementId
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Title in the schema.
        /// </summary>
        public virtual string Title
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for Content in the schema.
        /// </summary>
        public virtual byte[] Content
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

    
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        public virtual int Order
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for CurrentProgress in the schema.
        /// </summary>
        public virtual int CurrentProgress
        {
            get;
            set;
        }

    
        /// <summary>
        /// There are no comments for MinWordCount in the schema.
        /// </summary>
        public virtual int MinWordCount
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
    
        /// <summary>
        /// There are no comments for STRUCTUREELEMENT in the schema.
        /// </summary>
        public virtual STRUCTUREELEMENT STRUCTUREELEMENT
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for TASKs in the schema.
        /// </summary>
        public virtual ICollection<TASK> TASKs
        {
            get;
            set;
        }
    
        /// <summary>
        /// There are no comments for KEYWORDs in the schema.
        /// </summary>
        public virtual ICollection<KEYWORD> KEYWORDs
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
