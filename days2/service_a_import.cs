//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace days2
{
    using System;
    using System.Collections.Generic;
    
    public partial class service_a_import
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service_a_import()
        {
            this.ClientService = new HashSet<ClientService>();
            this.ServicePhoto1 = new HashSet<ServicePhoto1>();
        }
    
        public string Title { get; set; }
        public int MainImagePath { get; set; }
        public int DurationInSeconds { get; set; }
        public int Cost { get; set; }
        public int Discount { get; set; }
        public int id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientService> ClientService { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicePhoto1> ServicePhoto1 { get; set; }
    }
}