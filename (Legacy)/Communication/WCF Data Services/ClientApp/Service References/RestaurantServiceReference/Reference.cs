//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34014
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

// Исходное имя файла:
// Дата создания: 29.11.2014 11:35:37
namespace ClientApp.RestaurantServiceReference
{
    
    /// <summary>
    /// В схеме отсутствуют комментарии для RestaurantEntities.
    /// </summary>
    public partial class RestaurantEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Инициализируйте новый объект RestaurantEntities.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public RestaurantEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot, global::System.Data.Services.Common.DataServiceProtocolVersion.V3)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Поскольку пространство имен, настроенное для этой ссылки на службу
        /// в Visual Studio, отличается от пространства имен, указанного
        /// в схеме сервера, для сопоставления этих пространств имен используйте преобразователи типов.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("RestaurantModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("ClientApp.RestaurantServiceReference", typeName.Substring(15)), false);
            }
            return null;
        }
        /// <summary>
        /// Поскольку пространство имен, настроенное для этой ссылки на службу
        /// в Visual Studio, отличается от пространства имен, указанного
        /// в схеме сервера, для сопоставления этих пространств имен используйте преобразователи типов.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("ClientApp.RestaurantServiceReference", global::System.StringComparison.Ordinal))
            {
                return string.Concat("RestaurantModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для Categories.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Category> Categories
        {
            get
            {
                if ((this._Categories == null))
                {
                    this._Categories = base.CreateQuery<Category>("Categories");
                }
                return this._Categories;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Category> _Categories;
        /// <summary>
        /// В схеме отсутствуют комментарии для Menus.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceQuery<Menu> Menus
        {
            get
            {
                if ((this._Menus == null))
                {
                    this._Menus = base.CreateQuery<Menu>("Menus");
                }
                return this._Menus;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceQuery<Menu> _Menus;
        /// <summary>
        /// В схеме отсутствуют комментарии для Categories.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToCategories(Category category)
        {
            base.AddObject("Categories", category);
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для Menus.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public void AddToMenus(Menu menu)
        {
            base.AddObject("Menus", menu);
        }
    }
    /// <summary>
    /// В схеме отсутствуют комментарии для RestaurantModel.Category.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Categories")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Category : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Создайте новый объект Category.
        /// </summary>
        /// <param name="ID">Начальное значение Id.</param>
        /// <param name="name">Начальное значение Name.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Category CreateCategory(int ID, string name)
        {
            Category category = new Category();
            category.Id = ID;
            category.Name = name;
            return category;
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Id.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для Menus.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Data.Services.Client.DataServiceCollection<Menu> Menus
        {
            get
            {
                return this._Menus;
            }
            set
            {
                this._Menus = value;
                this.OnPropertyChanged("Menus");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Data.Services.Client.DataServiceCollection<Menu> _Menus = new global::System.Data.Services.Client.DataServiceCollection<Menu>(null, global::System.Data.Services.Client.TrackingMode.None);
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
    /// <summary>
    /// В схеме отсутствуют комментарии для RestaurantModel.Menu.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::System.Data.Services.Common.EntitySetAttribute("Menus")]
    [global::System.Data.Services.Common.DataServiceKeyAttribute("Id")]
    public partial class Menu : global::System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Создайте новый объект Menu.
        /// </summary>
        /// <param name="ID">Начальное значение Id.</param>
        /// <param name="categoryId">Начальное значение CategoryId.</param>
        /// <param name="name">Начальное значение Name.</param>
        /// <param name="active">Начальное значение Active.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public static Menu CreateMenu(int ID, int categoryId, string name, bool active)
        {
            Menu menu = new Menu();
            menu.Id = ID;
            menu.CategoryId = categoryId;
            menu.Name = name;
            menu.Active = active;
            return menu;
        }
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Id.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
                this.OnPropertyChanged("Id");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства CategoryId.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public int CategoryId
        {
            get
            {
                return this._CategoryId;
            }
            set
            {
                this.OnCategoryIdChanging(value);
                this._CategoryId = value;
                this.OnCategoryIdChanged();
                this.OnPropertyChanged("CategoryId");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private int _CategoryId;
        partial void OnCategoryIdChanging(int value);
        partial void OnCategoryIdChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Name.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
                this.OnPropertyChanged("Name");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Description.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public string Description
        {
            get
            {
                return this._Description;
            }
            set
            {
                this.OnDescriptionChanging(value);
                this._Description = value;
                this.OnDescriptionChanged();
                this.OnPropertyChanged("Description");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private string _Description;
        partial void OnDescriptionChanging(string value);
        partial void OnDescriptionChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Active.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public bool Active
        {
            get
            {
                return this._Active;
            }
            set
            {
                this.OnActiveChanging(value);
                this._Active = value;
                this.OnActiveChanged();
                this.OnPropertyChanged("Active");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private bool _Active;
        partial void OnActiveChanging(bool value);
        partial void OnActiveChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для свойства Price.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public global::System.Nullable<decimal> Price
        {
            get
            {
                return this._Price;
            }
            set
            {
                this.OnPriceChanging(value);
                this._Price = value;
                this.OnPriceChanged();
                this.OnPropertyChanged("Price");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private global::System.Nullable<decimal> _Price;
        partial void OnPriceChanging(global::System.Nullable<decimal> value);
        partial void OnPriceChanged();
        /// <summary>
        /// В схеме отсутствуют комментарии для Category.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public Category Category
        {
            get
            {
                return this._Category;
            }
            set
            {
                this._Category = value;
                this.OnPropertyChanged("Category");
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        private Category _Category;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Data.Services.Design", "1.0.0")]
        protected virtual void OnPropertyChanged(string property)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(property));
            }
        }
    }
}