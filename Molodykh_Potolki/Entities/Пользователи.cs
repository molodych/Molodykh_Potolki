//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Molodykh_Potolki.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Пользователи
    {
        public int код_пользователя { get; set; }
        public string логин { get; set; }
        public string пароль { get; set; }
        public int код_роли { get; set; }
    
        public virtual Роль_пользователя Роль_пользователя { get; set; }
    }
}
