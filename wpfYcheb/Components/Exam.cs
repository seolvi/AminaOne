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
    
    public partial class Exam
    {
        public int ID_Exam { get; set; }
        public System.DateTime Date { get; set; }
        public int ID_Discipline { get; set; }
        public int ID_Student { get; set; }
        public int Tab_Number { get; set; }
        public string Room { get; set; }
        public int Grade { get; set; }
    
        public virtual Discipline Discipline { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Student Student { get; set; }
    }
}
