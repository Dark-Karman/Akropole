//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Akropole.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rent
    {
        public int id { get; set; }
        public Nullable<int> idFlat { get; set; }
        public Nullable<System.DateTime> dateStart { get; set; }
    
        public virtual Flat Flat { get; set; }
    }
}
