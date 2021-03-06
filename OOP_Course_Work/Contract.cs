//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOP_Course_Work
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public Contract()
        {
            this.Client = new HashSet<Client>();
            this.Tur = new HashSet<Tur>();
            this.Hotel = new HashSet<Hotel>();
        }
    
        public int ContractID { get; set; }
        public string ClientID { get; set; }
        public string TurID { get; set; }
        public string HotelID { get; set; }
        public int Number { get; set; }
        public double Cost { get; set; }
        public Nullable<double> TotalCost { get; set; }
        public System.DateTime Date { get; set; }
    
        public virtual ICollection<Client> Client { get; set; }
        public virtual ICollection<Tur> Tur { get; set; }
        public virtual ICollection<Hotel> Hotel { get; set; }
    }
}
