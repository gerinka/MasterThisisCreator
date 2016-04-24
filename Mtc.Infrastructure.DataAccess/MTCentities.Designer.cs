﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Devart Entity Developer tool using Entity Framework EntityObject template.
// Code is generated on: 4/24/2016 6:51:28 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Reflection;
using System.Linq.Expressions;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Core.Objects.DataClasses;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("MtcModel", "FK_StructureElement_ID", "Structureelement", RelationshipMultiplicity.One, typeof(MtcModel.Structureelement), "Structurecontents", RelationshipMultiplicity.Many, typeof(MtcModel.Structurecontent), true)]
[assembly: EdmRelationshipAttribute("MtcModel", "FK_StructureType", "Structuretype", RelationshipMultiplicity.One, typeof(MtcModel.Structuretype), "Structureelements", RelationshipMultiplicity.Many, typeof(MtcModel.Structureelement), true)]
[assembly: EdmRelationshipAttribute("MtcModel", "Structureelement_Structureelement", "Structureelements1", RelationshipMultiplicity.Many, typeof(MtcModel.Structureelement), "Structureelements_structureelementchild", RelationshipMultiplicity.Many, typeof(MtcModel.Structureelement))]
[assembly: EdmRelationshipAttribute("MtcModel", "FK_User_ID", "User", RelationshipMultiplicity.One, typeof(MtcModel.User), "Structurecontents", RelationshipMultiplicity.Many, typeof(MtcModel.Structurecontent), true)]

#endregion

namespace MtcModel
{

    #region MtcEntities

    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MtcEntities : ObjectContext
    {
        #region Constructors

        /// <summary>
        /// Initialize a new MtcEntities object.
        /// </summary>
        public MtcEntities() : 
                base(@"name=MtcEntitiesConnectionString", "MtcEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initializes a new MtcEntities object using the connection string found in the 'MtcEntities' section of the application configuration file.
        /// </summary>
        public MtcEntities(string connectionString) : 
                base(connectionString, "MtcEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        /// <summary>
        /// Initialize a new MtcEntities object.
        /// </summary>
        public MtcEntities(EntityConnection connection) : base(connection, "MtcEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }

        #endregion

        #region Partial Methods

        partial void OnContextCreated();

        #endregion

        #region ObjectSet Properties

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Structurecontent> Structurecontents
        {
            get
            {
                if ((_Structurecontents == null))
                {
                    _Structurecontents = base.CreateObjectSet<Structurecontent>("Structurecontents");
                }
                return _Structurecontents;
            }
        }
        private ObjectSet<Structurecontent> _Structurecontents;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Structureelement> Structureelements
        {
            get
            {
                if ((_Structureelements == null))
                {
                    _Structureelements = base.CreateObjectSet<Structureelement>("Structureelements");
                }
                return _Structureelements;
            }
        }
        private ObjectSet<Structureelement> _Structureelements;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Structuretype> Structuretypes
        {
            get
            {
                if ((_Structuretypes == null))
                {
                    _Structuretypes = base.CreateObjectSet<Structuretype>("Structuretypes");
                }
                return _Structuretypes;
            }
        }
        private ObjectSet<Structuretype> _Structuretypes;

        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<User> Users
        {
            get
            {
                if ((_Users == null))
                {
                    _Users = base.CreateObjectSet<User>("Users");
                }
                return _Users;
            }
        }
        private ObjectSet<User> _Users;

        #endregion
        #region AddTo Methods

        /// <summary>
        /// Deprecated Method for adding a new object to the Structurecontents EntitySet.
        /// </summary>
        public void AddToStructurecontents(Structurecontent structurecontent)
        {
            base.AddObject("Structurecontents", structurecontent);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Structureelements EntitySet.
        /// </summary>
        public void AddToStructureelements(Structureelement structureelement)
        {
            base.AddObject("Structureelements", structureelement);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Structuretypes EntitySet.
        /// </summary>
        public void AddToStructuretypes(Structuretype structuretype)
        {
            base.AddObject("Structuretypes", structuretype);
        }

        /// <summary>
        /// Deprecated Method for adding a new object to the Users EntitySet.
        /// </summary>
        public void AddToUsers(User user)
        {
            base.AddObject("Users", user);
        }

        #endregion
    }

    #endregion
}

namespace MtcModel
{

    /// <summary>
    /// There are no comments for MtcModel.Structurecontent in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="MtcModel", Name="Structurecontent")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Structurecontent : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new Structurecontent object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="structureElementId">Initial value of StructureElementId.</param>
        /// <param name="userId">Initial value of UserId.</param>
        public static Structurecontent CreateStructurecontent(int iD, int structureElementId, int userId)
        {
            Structurecontent structurecontent = new Structurecontent();
            structurecontent.ID = iD;
            structurecontent.StructureElementId = structureElementId;
            structurecontent.UserId = userId;
            return structurecontent;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public int ID
        {
            get
            {
                int value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private int _ID;
        partial void OnGetID(ref int value);
        partial void OnIDChanging(ref int value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for StructureElementId in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public int StructureElementId
        {
            get
            {
                int value = _StructureElementId;
                OnGetStructureElementId(ref value);
                return value;
            }
            set
            {
                if (_StructureElementId != value)
                {
                  OnStructureElementIdChanging(ref value);
                  ReportPropertyChanging("StructureElementId");
                  _StructureElementId = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("StructureElementId");
                  OnStructureElementIdChanged();
              }
            }
        }
        private int _StructureElementId;
        partial void OnGetStructureElementId(ref int value);
        partial void OnStructureElementIdChanging(ref int value);
        partial void OnStructureElementIdChanged();
    
        /// <summary>
        /// There are no comments for Title in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string Title
        {
            get
            {
                string value = _Title;
                OnGetTitle(ref value);
                return value;
            }
            set
            {
                if (_Title != value)
                {
                  OnTitleChanging(ref value);
                  ReportPropertyChanging("Title");
                  _Title = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Title");
                  OnTitleChanged();
              }
            }
        }
        private string _Title;
        partial void OnGetTitle(ref string value);
        partial void OnTitleChanging(ref string value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// There are no comments for Content in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public byte[] Content
        {
            get
            {
                byte[] value = _Content;
                OnGetContent(ref value);
                return value;
            }
            set
            {
                if (_Content != value)
                {
                  OnContentChanging(ref value);
                  ReportPropertyChanging("Content");
                  _Content = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Content");
                  OnContentChanged();
              }
            }
        }
        private byte[] _Content;
        partial void OnGetContent(ref byte[] value);
        partial void OnContentChanging(ref byte[] value);
        partial void OnContentChanged();
    
        /// <summary>
        /// There are no comments for UserId in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public int UserId
        {
            get
            {
                int value = _UserId;
                OnGetUserId(ref value);
                return value;
            }
            set
            {
                if (_UserId != value)
                {
                  OnUserIdChanging(ref value);
                  ReportPropertyChanging("UserId");
                  _UserId = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("UserId");
                  OnUserIdChanged();
              }
            }
        }
        private int _UserId;
        partial void OnGetUserId(ref int value);
        partial void OnUserIdChanging(ref int value);
        partial void OnUserIdChanged();
    
        /// <summary>
        /// There are no comments for Order in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public global::System.Nullable<int> Order
        {
            get
            {
                global::System.Nullable<int> value = _Order;
                OnGetOrder(ref value);
                return value;
            }
            set
            {
                if (_Order != value)
                {
                  OnOrderChanging(ref value);
                  ReportPropertyChanging("Order");
                  _Order = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("Order");
                  OnOrderChanged();
              }
            }
        }
        private global::System.Nullable<int> _Order;
        partial void OnGetOrder(ref global::System.Nullable<int> value);
        partial void OnOrderChanging(ref global::System.Nullable<int> value);
        partial void OnOrderChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Structureelement in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_StructureElement_ID", "Structureelement")]
        public Structureelement Structureelement
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Structureelement>("MtcModel.FK_StructureElement_ID", "Structureelement").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Structureelement>("MtcModel.FK_StructureElement_ID", "Structureelement").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for Structureelement in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Structureelement> StructureelementReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Structureelement>("MtcModel.FK_StructureElement_ID", "Structureelement");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Structureelement>("MtcModel.FK_StructureElement_ID", "Structureelement", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Structureelement>("MtcModel.FK_StructureElement_ID", "Structureelement").Value = null;
                }
            }
        }
    
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_User_ID", "User")]
        public User User
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<User>("MtcModel.FK_User_ID", "User").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<User>("MtcModel.FK_User_ID", "User").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for User in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<User> UserReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<User>("MtcModel.FK_User_ID", "User");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<User>("MtcModel.FK_User_ID", "User", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<User>("MtcModel.FK_User_ID", "User").Value = null;
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// There are no comments for MtcModel.Structureelement in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="MtcModel", Name="Structureelement")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Structureelement : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new Structureelement object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="structureTypeId">Initial value of StructureTypeId.</param>
        public static Structureelement CreateStructureelement(int iD, int structureTypeId)
        {
            Structureelement structureelement = new Structureelement();
            structureelement.ID = iD;
            structureelement.StructureTypeId = structureTypeId;
            return structureelement;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public int ID
        {
            get
            {
                int value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private int _ID;
        partial void OnGetID(ref int value);
        partial void OnIDChanging(ref int value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for Title in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string Title
        {
            get
            {
                string value = _Title;
                OnGetTitle(ref value);
                return value;
            }
            set
            {
                if (_Title != value)
                {
                  OnTitleChanging(ref value);
                  ReportPropertyChanging("Title");
                  _Title = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Title");
                  OnTitleChanged();
              }
            }
        }
        private string _Title;
        partial void OnGetTitle(ref string value);
        partial void OnTitleChanging(ref string value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// There are no comments for StructureTypeId in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public int StructureTypeId
        {
            get
            {
                int value = _StructureTypeId;
                OnGetStructureTypeId(ref value);
                return value;
            }
            set
            {
                if (_StructureTypeId != value)
                {
                  OnStructureTypeIdChanging(ref value);
                  ReportPropertyChanging("StructureTypeId");
                  _StructureTypeId = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("StructureTypeId");
                  OnStructureTypeIdChanged();
              }
            }
        }
        private int _StructureTypeId;
        partial void OnGetStructureTypeId(ref int value);
        partial void OnStructureTypeIdChanging(ref int value);
        partial void OnStructureTypeIdChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Structurecontents in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_StructureElement_ID", "Structurecontents")]
        public EntityCollection<Structurecontent> Structurecontents
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Structurecontent>("MtcModel.FK_StructureElement_ID", "Structurecontents");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Structurecontent>("MtcModel.FK_StructureElement_ID", "Structurecontents", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for Structuretype in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_StructureType", "Structuretype")]
        public Structuretype Structuretype
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Structuretype>("MtcModel.FK_StructureType", "Structuretype").Value;
            }
            set
            {
                ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Structuretype>("MtcModel.FK_StructureType", "Structuretype").Value = value;
            }
        }
    
        /// <summary>
        /// There are no comments for Structuretype in the schema.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Structuretype> StructuretypeReference
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Structuretype>("MtcModel.FK_StructureType", "Structuretype");
            }
            set
            {
                if (value != null)
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedReference<Structuretype>("MtcModel.FK_StructureType", "Structuretype", value);
                }
                else 
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedReference<Structuretype>("MtcModel.FK_StructureType", "Structuretype").Value = null;
                }
            }
        }
    
        /// <summary>
        /// There are no comments for Structureelements_structureelementchild in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "Structureelement_Structureelement", "Structureelements_structureelementchild")]
        public EntityCollection<Structureelement> Structureelements_structureelementchild
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Structureelement>("MtcModel.Structureelement_Structureelement", "Structureelements_structureelementchild");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Structureelement>("MtcModel.Structureelement_Structureelement", "Structureelements_structureelementchild", value);
                }
            }
        }
    
        /// <summary>
        /// There are no comments for Structureelements1 in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "Structureelement_Structureelement", "Structureelements1")]
        public EntityCollection<Structureelement> Structureelements1
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Structureelement>("MtcModel.Structureelement_Structureelement", "Structureelements1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Structureelement>("MtcModel.Structureelement_Structureelement", "Structureelements1", value);
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// There are no comments for MtcModel.Structuretype in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="MtcModel", Name="Structuretype")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Structuretype : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new Structuretype object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        public static Structuretype CreateStructuretype(int iD)
        {
            Structuretype structuretype = new Structuretype();
            structuretype.ID = iD;
            return structuretype;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public int ID
        {
            get
            {
                int value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private int _ID;
        partial void OnGetID(ref int value);
        partial void OnIDChanging(ref int value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute()]
        [DataMemberAttribute()]
        public string Name
        {
            get
            {
                string value = _Name;
                OnGetName(ref value);
                return value;
            }
            set
            {
                if (_Name != value)
                {
                  OnNameChanging(ref value);
                  ReportPropertyChanging("Name");
                  _Name = StructuralObject.SetValidValue(value, true);
                  ReportPropertyChanged("Name");
                  OnNameChanged();
              }
            }
        }
        private string _Name;
        partial void OnGetName(ref string value);
        partial void OnNameChanging(ref string value);
        partial void OnNameChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Structureelements in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_StructureType", "Structureelements")]
        public EntityCollection<Structureelement> Structureelements
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Structureelement>("MtcModel.FK_StructureType", "Structureelements");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Structureelement>("MtcModel.FK_StructureType", "Structureelements", value);
                }
            }
        }

        #endregion
    }

    /// <summary>
    /// There are no comments for MtcModel.User in the schema.
    /// </summary>
    /// <KeyProperties>
    /// ID
    /// </KeyProperties>
    [EdmEntityTypeAttribute(NamespaceName="MtcModel", Name="User")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class User : EntityObject    {
        #region Factory Method

        /// <summary>
        /// Create a new User object.
        /// </summary>
        /// <param name="iD">Initial value of ID.</param>
        /// <param name="name">Initial value of Name.</param>
        /// <param name="userName">Initial value of UserName.</param>
        /// <param name="email">Initial value of Email.</param>
        /// <param name="password">Initial value of Password.</param>
        public static User CreateUser(int iD, string name, string userName, string email, string password)
        {
            User user = new User();
            user.ID = iD;
            user.Name = name;
            user.UserName = userName;
            user.Email = email;
            user.Password = password;
            return user;
        }

        #endregion

        #region Properties
    
        /// <summary>
        /// There are no comments for ID in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public int ID
        {
            get
            {
                int value = _ID;
                OnGetID(ref value);
                return value;
            }
            set
            {
                if (_ID != value)
                {
                  OnIDChanging(ref value);
                  ReportPropertyChanging("ID");
                  _ID = StructuralObject.SetValidValue(value);
                  ReportPropertyChanged("ID");
                  OnIDChanged();
              }
            }
        }
        private int _ID;
        partial void OnGetID(ref int value);
        partial void OnIDChanging(ref int value);
        partial void OnIDChanged();
    
        /// <summary>
        /// There are no comments for Name in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public string Name
        {
            get
            {
                string value = _Name;
                OnGetName(ref value);
                return value;
            }
            set
            {
                if (_Name != value)
                {
                  OnNameChanging(ref value);
                  ReportPropertyChanging("Name");
                  _Name = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Name");
                  OnNameChanged();
              }
            }
        }
        private string _Name;
        partial void OnGetName(ref string value);
        partial void OnNameChanging(ref string value);
        partial void OnNameChanged();
    
        /// <summary>
        /// There are no comments for UserName in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public string UserName
        {
            get
            {
                string value = _UserName;
                OnGetUserName(ref value);
                return value;
            }
            set
            {
                if (_UserName != value)
                {
                  OnUserNameChanging(ref value);
                  ReportPropertyChanging("UserName");
                  _UserName = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("UserName");
                  OnUserNameChanged();
              }
            }
        }
        private string _UserName;
        partial void OnGetUserName(ref string value);
        partial void OnUserNameChanging(ref string value);
        partial void OnUserNameChanged();
    
        /// <summary>
        /// There are no comments for Email in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public string Email
        {
            get
            {
                string value = _Email;
                OnGetEmail(ref value);
                return value;
            }
            set
            {
                if (_Email != value)
                {
                  OnEmailChanging(ref value);
                  ReportPropertyChanging("Email");
                  _Email = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Email");
                  OnEmailChanged();
              }
            }
        }
        private string _Email;
        partial void OnGetEmail(ref string value);
        partial void OnEmailChanging(ref string value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// There are no comments for Password in the schema.
        /// </summary>
        [EdmScalarPropertyAttribute(IsNullable=false)]
        [DataMemberAttribute()]
        public string Password
        {
            get
            {
                string value = _Password;
                OnGetPassword(ref value);
                return value;
            }
            set
            {
                if (_Password != value)
                {
                  OnPasswordChanging(ref value);
                  ReportPropertyChanging("Password");
                  _Password = StructuralObject.SetValidValue(value, false);
                  ReportPropertyChanged("Password");
                  OnPasswordChanged();
              }
            }
        }
        private string _Password;
        partial void OnGetPassword(ref string value);
        partial void OnPasswordChanging(ref string value);
        partial void OnPasswordChanged();

        #endregion

        #region Navigation Properties
    
        /// <summary>
        /// There are no comments for Structurecontents in the schema.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MtcModel", "FK_User_ID", "Structurecontents")]
        public EntityCollection<Structurecontent> Structurecontents
        {
            get
            {
                return ((IEntityWithRelationships)(this)).RelationshipManager.GetRelatedCollection<Structurecontent>("MtcModel.FK_User_ID", "Structurecontents");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)(this)).RelationshipManager.InitializeRelatedCollection<Structurecontent>("MtcModel.FK_User_ID", "Structurecontents", value);
                }
            }
        }

        #endregion
    }

}
