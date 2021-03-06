﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("BooksInfoModel", "FK_Book_Description_Books", "Book", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(BooksInfo.Models.Book), "Book_Description", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BooksInfo.Models.Book_Description), true)]
[assembly: EdmRelationshipAttribute("BooksInfoModel", "FK_Contributor_Books", "Book", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(BooksInfo.Models.Book), "Contributor", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(BooksInfo.Models.Contributor), true)]

#endregion

namespace BooksInfo.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class BooksInfoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new BooksInfoEntities object using the connection string found in the 'BooksInfoEntities' section of the application configuration file.
        /// </summary>
        public BooksInfoEntities() : base("name=BooksInfoEntities", "BooksInfoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BooksInfoEntities object.
        /// </summary>
        public BooksInfoEntities(string connectionString) : base(connectionString, "BooksInfoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new BooksInfoEntities object.
        /// </summary>
        public BooksInfoEntities(EntityConnection connection) : base(connection, "BooksInfoEntities")
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
        public ObjectSet<Book_Description> Book_Description
        {
            get
            {
                if ((_Book_Description == null))
                {
                    _Book_Description = base.CreateObjectSet<Book_Description>("Book_Description");
                }
                return _Book_Description;
            }
        }
        private ObjectSet<Book_Description> _Book_Description;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Book> Books
        {
            get
            {
                if ((_Books == null))
                {
                    _Books = base.CreateObjectSet<Book>("Books");
                }
                return _Books;
            }
        }
        private ObjectSet<Book> _Books;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Contributor> Contributors
        {
            get
            {
                if ((_Contributors == null))
                {
                    _Contributors = base.CreateObjectSet<Contributor>("Contributors");
                }
                return _Contributors;
            }
        }
        private ObjectSet<Contributor> _Contributors;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Book_Description EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBook_Description(Book_Description book_Description)
        {
            base.AddObject("Book_Description", book_Description);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Books EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToBooks(Book book)
        {
            base.AddObject("Books", book);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Contributors EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToContributors(Contributor contributor)
        {
            base.AddObject("Contributors", contributor);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BooksInfoModel", Name="Book")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book object.
        /// </summary>
        /// <param name="id">Initial value of the ID property.</param>
        /// <param name="book_ID">Initial value of the Book_ID property.</param>
        public static Book CreateBook(global::System.Int64 id, global::System.Int64 book_ID)
        {
            Book book = new Book();
            book.ID = id;
            book.Book_ID = book_ID;
            return book;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ID
        {
            get
            {
                return _ID;
            }
            set
            {
                if (_ID != value)
                {
                    OnIDChanging(value);
                    ReportPropertyChanging("ID");
                    _ID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ID");
                    OnIDChanged();
                }
            }
        }
        private global::System.Int64 _ID;
        partial void OnIDChanging(global::System.Int64 value);
        partial void OnIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 Book_ID
        {
            get
            {
                return _Book_ID;
            }
            set
            {
                OnBook_IDChanging(value);
                ReportPropertyChanging("Book_ID");
                _Book_ID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Book_ID");
                OnBook_IDChanged();
            }
        }
        private global::System.Int64 _Book_ID;
        partial void OnBook_IDChanging(global::System.Int64 value);
        partial void OnBook_IDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String alias
        {
            get
            {
                return _alias;
            }
            set
            {
                OnaliasChanging(value);
                ReportPropertyChanging("alias");
                _alias = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("alias");
                OnaliasChanged();
            }
        }
        private global::System.String _alias;
        partial void OnaliasChanging(global::System.String value);
        partial void OnaliasChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String url
        {
            get
            {
                return _url;
            }
            set
            {
                OnurlChanging(value);
                ReportPropertyChanging("url");
                _url = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("url");
                OnurlChanged();
            }
        }
        private global::System.String _url;
        partial void OnurlChanging(global::System.String value);
        partial void OnurlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String image_url
        {
            get
            {
                return _image_url;
            }
            set
            {
                Onimage_urlChanging(value);
                ReportPropertyChanging("image_url");
                _image_url = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("image_url");
                Onimage_urlChanged();
            }
        }
        private global::System.String _image_url;
        partial void Onimage_urlChanging(global::System.String value);
        partial void Onimage_urlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ISBN
        {
            get
            {
                return _ISBN;
            }
            set
            {
                OnISBNChanging(value);
                ReportPropertyChanging("ISBN");
                _ISBN = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ISBN");
                OnISBNChanged();
            }
        }
        private global::System.String _ISBN;
        partial void OnISBNChanging(global::System.String value);
        partial void OnISBNChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> ratingcount
        {
            get
            {
                return _ratingcount;
            }
            set
            {
                OnratingcountChanging(value);
                ReportPropertyChanging("ratingcount");
                _ratingcount = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("ratingcount");
                OnratingcountChanged();
            }
        }
        private Nullable<global::System.Int32> _ratingcount;
        partial void OnratingcountChanging(Nullable<global::System.Int32> value);
        partial void OnratingcountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String label
        {
            get
            {
                return _label;
            }
            set
            {
                OnlabelChanging(value);
                ReportPropertyChanging("label");
                _label = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("label");
                OnlabelChanged();
            }
        }
        private global::System.String _label;
        partial void OnlabelChanging(global::System.String value);
        partial void OnlabelChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Price
        {
            get
            {
                return _Price;
            }
            set
            {
                OnPriceChanging(value);
                ReportPropertyChanging("Price");
                _Price = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Price");
                OnPriceChanged();
            }
        }
        private global::System.String _Price;
        partial void OnPriceChanging(global::System.String value);
        partial void OnPriceChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Boolean> IsMarked
        {
            get
            {
                return _IsMarked;
            }
            set
            {
                OnIsMarkedChanging(value);
                ReportPropertyChanging("IsMarked");
                _IsMarked = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IsMarked");
                OnIsMarkedChanged();
            }
        }
        private Nullable<global::System.Boolean> _IsMarked;
        partial void OnIsMarkedChanging(Nullable<global::System.Boolean> value);
        partial void OnIsMarkedChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BooksInfoModel", "FK_Book_Description_Books", "Book_Description")]
        public EntityCollection<Book_Description> Book_Description
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Book_Description>("BooksInfoModel.FK_Book_Description_Books", "Book_Description");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Book_Description>("BooksInfoModel.FK_Book_Description_Books", "Book_Description", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BooksInfoModel", "FK_Contributor_Books", "Contributor")]
        public EntityCollection<Contributor> Contributors
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Contributor>("BooksInfoModel.FK_Contributor_Books", "Contributor");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Contributor>("BooksInfoModel.FK_Contributor_Books", "Contributor", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BooksInfoModel", Name="Book_Description")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Book_Description : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Book_Description object.
        /// </summary>
        /// <param name="descriptionID">Initial value of the DescriptionID property.</param>
        public static Book_Description CreateBook_Description(global::System.Int64 descriptionID)
        {
            Book_Description book_Description = new Book_Description();
            book_Description.DescriptionID = descriptionID;
            return book_Description;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 DescriptionID
        {
            get
            {
                return _DescriptionID;
            }
            set
            {
                if (_DescriptionID != value)
                {
                    OnDescriptionIDChanging(value);
                    ReportPropertyChanging("DescriptionID");
                    _DescriptionID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DescriptionID");
                    OnDescriptionIDChanged();
                }
            }
        }
        private global::System.Int64 _DescriptionID;
        partial void OnDescriptionIDChanging(global::System.Int64 value);
        partial void OnDescriptionIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int64> BookID
        {
            get
            {
                return _BookID;
            }
            set
            {
                OnBookIDChanging(value);
                ReportPropertyChanging("BookID");
                _BookID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BookID");
                OnBookIDChanged();
            }
        }
        private Nullable<global::System.Int64> _BookID;
        partial void OnBookIDChanging(Nullable<global::System.Int64> value);
        partial void OnBookIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Description
        {
            get
            {
                return _Description;
            }
            set
            {
                OnDescriptionChanging(value);
                ReportPropertyChanging("Description");
                _Description = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Description");
                OnDescriptionChanged();
            }
        }
        private global::System.String _Description;
        partial void OnDescriptionChanging(global::System.String value);
        partial void OnDescriptionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> Date_Created
        {
            get
            {
                return _Date_Created;
            }
            set
            {
                OnDate_CreatedChanging(value);
                ReportPropertyChanging("Date_Created");
                _Date_Created = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Date_Created");
                OnDate_CreatedChanged();
            }
        }
        private Nullable<global::System.DateTime> _Date_Created;
        partial void OnDate_CreatedChanging(Nullable<global::System.DateTime> value);
        partial void OnDate_CreatedChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BooksInfoModel", "FK_Book_Description_Books", "Book")]
        public Book Book
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BooksInfoModel.FK_Book_Description_Books", "Book").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BooksInfoModel.FK_Book_Description_Books", "Book").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Book> BookReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BooksInfoModel.FK_Book_Description_Books", "Book");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Book>("BooksInfoModel.FK_Book_Description_Books", "Book", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="BooksInfoModel", Name="Contributor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Contributor : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Contributor object.
        /// </summary>
        /// <param name="contributorID">Initial value of the ContributorID property.</param>
        /// <param name="bookID">Initial value of the BookID property.</param>
        public static Contributor CreateContributor(global::System.Int64 contributorID, global::System.Int64 bookID)
        {
            Contributor contributor = new Contributor();
            contributor.ContributorID = contributorID;
            contributor.BookID = bookID;
            return contributor;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 ContributorID
        {
            get
            {
                return _ContributorID;
            }
            set
            {
                if (_ContributorID != value)
                {
                    OnContributorIDChanging(value);
                    ReportPropertyChanging("ContributorID");
                    _ContributorID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("ContributorID");
                    OnContributorIDChanged();
                }
            }
        }
        private global::System.Int64 _ContributorID;
        partial void OnContributorIDChanging(global::System.Int64 value);
        partial void OnContributorIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String alias
        {
            get
            {
                return _alias;
            }
            set
            {
                OnaliasChanging(value);
                ReportPropertyChanging("alias");
                _alias = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("alias");
                OnaliasChanged();
            }
        }
        private global::System.String _alias;
        partial void OnaliasChanging(global::System.String value);
        partial void OnaliasChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Url
        {
            get
            {
                return _Url;
            }
            set
            {
                OnUrlChanging(value);
                ReportPropertyChanging("Url");
                _Url = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Url");
                OnUrlChanged();
            }
        }
        private global::System.String _Url;
        partial void OnUrlChanging(global::System.String value);
        partial void OnUrlChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int64 BookID
        {
            get
            {
                return _BookID;
            }
            set
            {
                OnBookIDChanging(value);
                ReportPropertyChanging("BookID");
                _BookID = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("BookID");
                OnBookIDChanged();
            }
        }
        private global::System.Int64 _BookID;
        partial void OnBookIDChanging(global::System.Int64 value);
        partial void OnBookIDChanged();

        #endregion

    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("BooksInfoModel", "FK_Contributor_Books", "Book")]
        public Book Book
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BooksInfoModel.FK_Contributor_Books", "Book").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BooksInfoModel.FK_Contributor_Books", "Book").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Book> BookReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Book>("BooksInfoModel.FK_Contributor_Books", "Book");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Book>("BooksInfoModel.FK_Contributor_Books", "Book", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}
