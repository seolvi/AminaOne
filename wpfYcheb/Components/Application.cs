//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wpfYcheb.Components
{
    using System;
    using System.Collections.Generic;
    
    public partial class Application
    {
        public int ID_Application { get; set; }
        public string Number_Specialization { get; set; }
    
        public virtual Specialization Specialization { get; set; }
    }
}
