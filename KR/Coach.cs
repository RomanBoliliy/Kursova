//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KR
{
    using System;
    using System.Collections.Generic;
    
    public partial class Coach
    {
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Nickname { get; set; }
        public string Last_Name { get; set; }
        public Nullable<int> Team_ID { get; set; }
    
        public virtual Team Team { get; set; }
    }
}
