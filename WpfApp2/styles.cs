//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class styles
    {
        public styles()
        {
            this.albums = new HashSet<albums>();
        }
    
        public int style_id { get; set; }
        public string name { get; set; }
    
        public virtual ICollection<albums> albums { get; set; }
    }
}
